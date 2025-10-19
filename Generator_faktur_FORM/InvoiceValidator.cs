using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Generator_faktur_FORM
{
    public class InvoiceValidator
    {
        public List<string> Validate(Invoice invoice)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(invoice.SupplierName))
            {
                errors.Add("Jméno dodavatele nesmí být prázdné.");
            }

            if (string.IsNullOrWhiteSpace(invoice.CustomerName))
            {
                errors.Add("Jméno zákazníka nesmí být prázdné.");
            }

            if (!Regex.IsMatch(invoice.SupplierICO ?? "", @"^\d{8}$"))
            {
                errors.Add("IČO dodavatele musí obsahovat přesně 8 číslic.");
            }

            if (!Regex.IsMatch(invoice.CustomerICO ?? "", @"^\d{8}$"))
            {
                errors.Add("IČO zákazníka musí obsahovat přesně 8 číslic.");
            }

            if (invoice.Quantity <= 0)
            {
                errors.Add("Množství musí být větší než nula.");
            }

            if (invoice.Price <= 0)
            {
                errors.Add("Cena musí být větší než nula.");
            }

            if(string.IsNullOrWhiteSpace(invoice.ItemDescription))
            {
                errors.Add("Popis nesmí být prázdné.");
            }
            return errors;
        }

    }
}
