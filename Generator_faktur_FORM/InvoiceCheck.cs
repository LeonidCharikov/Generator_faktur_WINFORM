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
    public partial class InvoiceCheck : Form
    {

        private readonly Invoice _invoice;
        private readonly InvoiceService _invoiceService;


        public InvoiceCheck(Invoice invoice)
        {
            InitializeComponent();
            _invoice = invoice;
            _invoiceService = new InvoiceService();
            DisplayInvoiceData();
        }

        private void InvoiceCheck_Load(object sender, EventArgs e)
        {

        }

        private void DisplayInvoiceData()
        {
            // Zobrazení dat v labelech nebo needitovatelných textových polích
            lblId.Text = _invoice.Id;
            lblDate.Text = _invoice.IssueDate.ToString("dd.MM.yyyy");
            lblSupplier.Text = $"{_invoice.SupplierName} (IČO: {_invoice.SupplierICO})";
            lblCustomer.Text = $"{_invoice.CustomerName} (IČO: {_invoice.CustomerICO})";
            lblItem.Text = $"{_invoice.ItemDescription}";
            lblQuantity.Text = _invoice.Quantity.ToString();
            CultureInfo czechCulture = new CultureInfo("cs-CZ");
            lblPrice.Text = _invoice.Price.ToString("C", czechCulture);
            lblTotal.Text = _invoice.Total.ToString("C", czechCulture);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Kontrola, zda je zaškrtnutý checkbox
            if (!chkConfirm.Checked)
            {
                MessageBox.Show("Před uložením musíte potvrdit správnost údajů.", "Potvrzení chybí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Otevření dialogu pro uložení souboru
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "ISDOC soubor (*.isdoc)|*.isdoc|Všechny soubory (*.*)|*.*";
                saveFileDialog.Title = "Uložit fakturu";
                saveFileDialog.FileName = $"{_invoice.Id}.isdoc"; // Předvyplnění názvu souboru

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Získání cesty k souboru od uživatele
                    string filePath = saveFileDialog.FileName;

                    // Volání služby pro vytvoření a uložení souboru
                    bool success = _invoiceService.CreateInvoice(_invoice, filePath);
                    // Kontrola úspěšnosti operace
                    if (success)
                    {
                        MessageBox.Show($"Faktura byla úspěšně uložena do:\n{filePath}", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        using (MainForm mainForm = new MainForm())
                        {
                            this.Hide();
                            mainForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Došlo k chybě při ukládání faktury.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
