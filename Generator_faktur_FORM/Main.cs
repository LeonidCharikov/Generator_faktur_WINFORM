using System;
using System.Windows.Forms;

namespace Generator_faktur_FORM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Otevře formulář pro vytvoření nové faktury
            using (CreateInvoice createForm = new CreateInvoice())
            {
                this.Hide();
                createForm.ShowDialog();
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Instance třídy InvoiceService pro práci se soubory faktur
            InvoiceService invoiceService = new InvoiceService();

            // Použijeme OpenFileDialog, pro otevření existující faktury
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Otevřít fakturu";
                // Nastavíme filtr vyhledávaných souborů na ISDOC formát
                openFileDialog.Filter = "ISDOC soubory (*.isdoc)|*.isdoc|Všechny soubory (*.*)|*.*";

                // Zobrazíme dialog a pokud uživatel vybere soubor a klikne na OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // zisk cesty k vybranému souboru
                    string filePath = openFileDialog.FileName;

                    // Volání metody pro načtení faktury ze souboru
                    Invoice loadedInvoice = invoiceService.ReadInvoice(filePath, out string error);

                    // Kontrola načtení faktury
                    if (loadedInvoice != null)
                    {
                        using (InvoiceOpen openForm = new InvoiceOpen(loadedInvoice))
                        {
                            this.Hide();
                            openForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Chyba při načítání faktury:\n{error}", "Chyba souboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        // Aktualizace data a času v hlavním formuláři
        private void timer1_Tick(object sender, EventArgs e)
        {
            datetxt.Text = DateTime.Now.ToLongDateString();
            timetxt.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
