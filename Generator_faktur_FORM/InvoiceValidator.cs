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

            // Přidat .Trim(), aby se ignorovaly náhodné mezery
            string supIco = invoice.SupplierICO?.Trim() ?? "";
            string custIco = invoice.CustomerICO?.Trim() ?? "";

            if (!Regex.IsMatch(supIco, @"^\d{8}$"))
            {
                errors.Add($"IČO dodavatele '{supIco}' je chybné. Musí obsahovat přesně 8 číslic.");
            }

            if (!Regex.IsMatch(custIco, @"^\d{8}$"))
            {
                errors.Add($"IČO zákazníka '{custIco}' je chybné. Musí obsahovat přesně 8 číslic.");
            }

            // Validace položek
            if (invoice.Items == null || invoice.Items.Count == 0)
            {
                errors.Add("Faktura musí obsahovat alespoň jednu položku.");
            }

            return errors;
        }

    }
}
