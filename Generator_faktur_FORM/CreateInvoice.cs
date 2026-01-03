using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_faktur_FORM
{
    public partial class CreateInvoice : Form
    {
        // Použijeme BindingList pro automatické propojení s DataGridView
        private BindingList<InvoiceItem> _items;

        public CreateInvoice()
        {
            InitializeComponent();
            _items = new BindingList<InvoiceItem>();
        }

        private void CreateInvoice_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // Nastavení zdroje dat pro tabulku
            dgvItems.DataSource = _items;

        }

        private void ConfigureGrid()
        {
            // Přejmenování sloupců pro uživatele (pokud se nevygenerují automaticky správně)
            if (dgvItems.Columns["Description"] != null) dgvItems.Columns["Description"].HeaderText = "Popis";
            if (dgvItems.Columns["Quantity"] != null) dgvItems.Columns["Quantity"].HeaderText = "Množství";
            if (dgvItems.Columns["UnitPrice"] != null) dgvItems.Columns["UnitPrice"].HeaderText = "Cena za KS";
            if (dgvItems.Columns["TotalPrice"] != null) dgvItems.Columns["TotalPrice"].HeaderText = "Celkem";
        }

        // Tlačítko pro PŘIDÁNÍ jedné položky do seznamu
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Validace vstupů pro položku
            if (string.IsNullOrWhiteSpace(txtItemDescription.Text) ||
                !decimal.TryParse(txtQuantity.Text, out decimal qty) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Vyplňte správně popis, množství a cenu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vytvoření a přidání položky
            var newItem = new InvoiceItem
            {
                Description = txtItemDescription.Text,
                Quantity = qty,
                UnitPrice = price
            };

            _items.Add(newItem); // Tabulka se sama aktualizuje

            // Vyčištění políček pro další zadání
            txtItemDescription.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtItemDescription.Focus();
            timer1.Start();

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validace hlavičky faktury
            if (!DateTime.TryParseExact(txtDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Zkontrolujte formát data.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sestavení faktury
            Invoice invoiceToValidate = new Invoice
            {
                Id = txtId.Text,
                IssueDate = date,
                SupplierName = txtSupplierName.Text,
                SupplierICO = txtSupplierICO.Text,
                CustomerName = txtCustomerName.Text,
                CustomerICO = txtCustomerICO.Text,
                // Položky převedeme z BindingList do List
                Items = _items.ToList()
            };

            // Validace
            var validator = new InvoiceValidator();
            var errors = validator.Validate(invoiceToValidate);

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Chyba validace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Otevření kontroly
            using (InvoiceCheck checkForm = new InvoiceCheck(invoiceToValidate))
            {
                if (checkForm.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            using (MainForm mainForm = new MainForm())
            {
                this.Hide();
                mainForm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetxt.Text = DateTime.Now.ToLongDateString();
        }
    }
}