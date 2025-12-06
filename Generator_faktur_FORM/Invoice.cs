using System;
using System.Collections.Generic;
using System.Linq;

namespace Generator_faktur_FORM
{
    public class Invoice
    {
        // Inicializace seznamu v konstruktoru, aby nebyl null
        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }

        public string Id { get; set; }
        public DateTime IssueDate { get; set; }
        public string SupplierName { get; set; }
        public string SupplierICO { get; set; }
        public string CustomerName { get; set; }
        public string CustomerICO { get; set; }

        // Seznam položek
        public List<InvoiceItem> Items { get; set; }

        // Celková cena se počítá dynamicky ze seznamu položek
        public decimal TotalAmount => Items.Sum(i => i.TotalPrice);
    }
}