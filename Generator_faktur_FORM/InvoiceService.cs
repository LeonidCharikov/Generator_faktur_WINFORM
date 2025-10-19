using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Globalization;

namespace Generator_faktur_FORM
{
    public class InvoiceService
    {
        public bool CreateInvoice(Invoice invoice, string filePath)
        {
            try
            {
                decimal tax = invoice.Total * 0.21m;
                XNamespace ns = "http://isdoc.cz/namespace/2013";

                XDocument doc = new XDocument(
                    new XElement(ns + "Invoice",
                        new XAttribute("version", "6.0.2"),
                        new XElement(ns + "ID", invoice.Id),
                        new XElement(ns + "UUID", Guid.NewGuid().ToString()),
                        new XElement(ns + "IssueDate", invoice.IssueDate.ToString("yyyy-MM-dd")),
                        // ... (zbytek XML struktury, jako ve vašem původním kódu)
                        // Nahraďte proměnné vlastnostmi z objektu 'invoice'
                        new XElement(ns + "AccountingSupplierParty",
                            new XElement(ns + "Party",
                                new XElement(ns + "PartyIdentification", new XElement(ns + "ID", invoice.SupplierICO)),
                                new XElement(ns + "PartyName", new XElement(ns + "Name", invoice.SupplierName))
                            // ... atd.
                            )
                        ),
                        new XElement(ns + "AccountingCustomerParty",
                             new XElement(ns + "Party",
                                new XElement(ns + "PartyIdentification", new XElement(ns + "ID", invoice.CustomerICO)),
                                new XElement(ns + "PartyName", new XElement(ns + "Name", invoice.CustomerName))
                            // ... atd.
                            )
                        ),
                        new XElement(ns + "InvoiceLines",
                            new XElement(ns + "InvoiceLine",
                                new XElement(ns + "ID", "1"),
                                new XElement(ns + "InvoicedQuantity", new XAttribute("unitCode", "Ks"), invoice.Quantity),
                                new XElement(ns + "LineExtensionAmount", invoice.Total),
                                new XElement(ns + "UnitPrice", invoice.Price),
                                new XElement(ns + "Item", new XElement(ns + "Description", invoice.ItemDescription))
                            // ... atd.
                            )
                        ),
                        new XElement(ns + "LegalMonetaryTotal",
                            new XElement(ns + "TaxExclusiveAmount", invoice.Total),
                            new XElement(ns + "TaxInclusiveAmount", invoice.Total + tax),
                            new XElement(ns + "PayableAmount", invoice.Total + tax)
                        // ... atd.
                        )
                    )
                );

                using (StreamWriter sw = new StreamWriter(filePath, false, new UTF8Encoding(false)))
                {
                    doc.Save(sw);
                }
                return true;
            }
            catch (Exception)
            {
                // Zde by mělo být logování chyby
                return false;
            }
        }

        public Invoice ReadInvoice(string filePath, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                XDocument doc = XDocument.Load(filePath);
                XNamespace ns = "http://isdoc.cz/namespace/2013"; // Důležitý jmenný prostor!

                // Najdeme první (a v našem případě jediný) řádek faktury
                var invoiceLine = doc.Root.Element(ns + "InvoiceLines")?.Element(ns + "InvoiceLine");
                if (invoiceLine == null)
                {
                    throw new InvalidDataException("Soubor neobsahuje řádky faktury (InvoiceLines).");
                }

                // Vytvoříme a naplníme Invoice objekt daty z XML
                Invoice invoice = new Invoice
                {
                    Id = doc.Root.Element(ns + "ID")?.Value,
                    IssueDate = DateTime.Parse(doc.Root.Element(ns + "IssueDate")?.Value),

                    SupplierName = doc.Root.Element(ns + "AccountingSupplierParty")?.Element(ns + "Party")?.Element(ns + "PartyName")?.Element(ns + "Name")?.Value,
                    SupplierICO = doc.Root.Element(ns + "AccountingSupplierParty")?.Element(ns + "Party")?.Element(ns + "PartyIdentification")?.Element(ns + "ID")?.Value,

                    CustomerName = doc.Root.Element(ns + "AccountingCustomerParty")?.Element(ns + "Party")?.Element(ns + "PartyName")?.Element(ns + "Name")?.Value,
                    CustomerICO = doc.Root.Element(ns + "AccountingCustomerParty")?.Element(ns + "Party")?.Element(ns + "PartyIdentification")?.Element(ns + "ID")?.Value,

                    ItemDescription = invoiceLine.Element(ns + "Item")?.Element(ns + "Description")?.Value,
                    // Používáme CultureInfo.InvariantCulture, abychom správně parsovali desetinnou tečku
                    Quantity = decimal.Parse(invoiceLine.Element(ns + "InvoicedQuantity")?.Value, CultureInfo.InvariantCulture),
                    Price = decimal.Parse(invoiceLine.Element(ns + "UnitPrice")?.Value, CultureInfo.InvariantCulture)
                };

                return invoice;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return null; // V případě chyby vrátíme null
            }
        }
    }
}
