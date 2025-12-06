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

namespace Generator_faktur_FORM
{
    public partial class InvoiceOpen : Form
    {
        private readonly Invoice _invoice;

        public InvoiceOpen(Invoice invoice)
        {
            InitializeComponent();
            _invoice = invoice;
            DisplayInvoiceData(); // Zavoláme metodu pro zobrazení
        }

        private void InvoiceOpen_Load(object sender, EventArgs e)
        {

        }

        private void DisplayInvoiceData()
        {
            // Zkontrolujeme, zda data nejsou null, pro jistotu
            if (_invoice == null)
            {
                MessageBox.Show("Nepodařilo se načíst data faktury.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Zobrazení dat v labelech
            lblId.Text = _invoice.Id;
            lblDate.Text = _invoice.IssueDate.ToString("dd.MM.yyyy");
            lblSupplier.Text = $"{_invoice.SupplierName} (IČO: {_invoice.SupplierICO})";
            lblCustomer.Text = $"{_invoice.CustomerName} (IČO: {_invoice.CustomerICO})";
            dgvPreview.DataSource = _invoice.Items;
            CultureInfo czechCulture = new CultureInfo("cs-CZ");
            lblTotal.Text = _invoice.TotalAmount.ToString("C", czechCulture);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            using (MainForm mainForm = new MainForm())
            {
                this.Hide();
                mainForm.ShowDialog();
            }
        }
    }
}
