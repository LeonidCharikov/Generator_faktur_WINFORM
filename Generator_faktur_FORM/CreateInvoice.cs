using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Generator_faktur_FORM
{
    public partial class CreateInvoice : Form
    {
        public CreateInvoice()
        {
            InitializeComponent();
        }


        private void CreateInvoice_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // 1. Validace vstupů
            if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || !decimal.TryParse(txtPrice.Text, out decimal price) || !DateTime.TryParseExact(txtDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Zkontrolujte prosím formát data, množství a ceny.", "Chybný formát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Sestavení objektu faktury z dat ve formuláři
            Invoice invoiceToValidate = new Invoice
            {
                Id = txtId.Text,
                IssueDate = DateTime.ParseExact(txtDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture),
                SupplierName = txtSupplierName.Text,
                SupplierICO = txtSupplierICO.Text,
                CustomerName = txtCustomerName.Text,
                CustomerICO = txtCustomerICO.Text,
                ItemDescription = txtItemDescription.Text,
                Quantity = decimal.Parse(txtQuantity.Text),
                Price = decimal.Parse(txtPrice.Text)
            };

            var validator = new InvoiceValidator();
            List<string> validationErrors = validator.Validate(invoiceToValidate);

            // Zkontrolujeme, zda existují nějaké chyby
            if (validationErrors.Any()) // .Any() je z System.Linq
            {
                // Spojíme všechny chyby do jedné zprávy
                string errorMessage = string.Join("\n", validationErrors);
                MessageBox.Show(errorMessage, "Chyba validace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Zastavíme další zpracování
            }



            // 3. Otevření kontrolního formuláře a předání dat
            using (InvoiceCheck checkForm = new InvoiceCheck(invoiceToValidate))
            {
                // Zobrazíme kontrolní formulář a počkáme na jeho výsledek.
                DialogResult result = checkForm.ShowDialog();

                // Pokud uživatel v kontrolním okně potvrdil a úspěšně uložil (výsledek je OK)...
                if (result == DialogResult.OK)
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

        //Zapnutí časovače pro zobrazení data
        private void timer1_Tick(object sender, EventArgs e)
        {
            datetxt.Text = DateTime.Now.ToLongDateString();
        }
    }
}

