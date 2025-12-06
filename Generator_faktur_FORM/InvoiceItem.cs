using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_faktur_FORM
{
    public class InvoiceItem
    {
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Vypočítaná vlastnost (Read-only)
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}
