using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_faktur_FORM
{
    public class Invoice
    {
        public string Id { get; set; }
        public DateTime IssueDate { get; set; }
        public string SupplierName { get; set; }
        public string SupplierICO { get; set; }
        public string CustomerName { get; set; }
        public string CustomerICO { get; set; }
        public string ItemDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total => Quantity * Price; // Vypočítávaná vlastnost
    }
}
