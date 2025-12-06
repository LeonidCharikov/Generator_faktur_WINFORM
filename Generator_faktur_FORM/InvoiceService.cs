using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Generator_faktur_FORM
{
    public class InvoiceService
    {
        public bool CreateInvoice(Invoice invoice, string filePath)
        {
            try
            {
                // Celková daň ze součtu položek
                decimal tax = invoice.TotalAmount * 0.21m;
                XNamespace ns = "http://isdoc.cz/namespace/2013";

                // Vytvoření elementu InvoiceLines
                XElement invoiceLinesElement = new XElement(ns + "InvoiceLines");

                // Cyklus pro přidání všech položek
                int lineId = 1;
                foreach (var item in invoice.Items)
                {
                    invoiceLinesElement.Add(
                        new XElement(ns + "InvoiceLine",
                            new XElement(ns + "ID", lineId++),
                            new XElement(ns + "InvoicedQuantity", new XAttribute("unitCode", "Ks"), item.Quantity.ToString(CultureInfo.InvariantCulture)),
                            new XElement(ns + "LineExtensionAmount", item.TotalPrice.ToString(CultureInfo.InvariantCulture)),
                            new XElement(ns + "UnitPrice", item.UnitPrice.ToString(CultureInfo.InvariantCulture)),
                            new XElement(ns + "Item",
                                new XElement(ns + "Description", item.Description)
                            )
                        )
                    );
                }

                XDocument doc = new XDocument(
                    new XElement(ns + "Invoice",
                        new XAttribute("version", "6.0.2"),
                        new XElement(ns + "ID", invoice.Id),
                        new XElement(ns + "UUID", Guid.NewGuid().ToString()),
                        new XElement(ns + "IssueDate", invoice.IssueDate.ToString("yyyy-MM-dd")),

                        // Dodavatel
                        new XElement(ns + "AccountingSupplierParty",
                            new XElement(ns + "Party",
                                new XElement(ns + "PartyIdentification", new XElement(ns + "ID", invoice.SupplierICO)),
                                new XElement(ns + "PartyName", new XElement(ns + "Name", invoice.SupplierName))
                            )
                        ),
                        // Zákazník
                        new XElement(ns + "AccountingCustomerParty",
                             new XElement(ns + "Party",
                                new XElement(ns + "PartyIdentification", new XElement(ns + "ID", invoice.CustomerICO)),
                                new XElement(ns + "PartyName", new XElement(ns + "Name", invoice.CustomerName))
                            )
                        ),

                        // Zde vložíme připravené řádky
                        invoiceLinesElement,

                        // Celkové součty
                        new XElement(ns + "LegalMonetaryTotal",
                            new XElement(ns + "TaxExclusiveAmount", invoice.TotalAmount.ToString(CultureInfo.InvariantCulture)),
                            new XElement(ns + "TaxInclusiveAmount", (invoice.TotalAmount + tax).ToString(CultureInfo.InvariantCulture)),
                            new XElement(ns + "PayableAmount", (invoice.TotalAmount + tax).ToString(CultureInfo.InvariantCulture))
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
                // Zde doporučuji do budoucna logovat konkrétní chybu (ex.Message)
                return false;
            }
        }

        public Invoice ReadInvoice(string filePath, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                XDocument doc = XDocument.Load(filePath);
                XNamespace ns = "http://isdoc.cz/namespace/2013";

                Invoice invoice = new Invoice
                {
                    Id = doc.Root.Element(ns + "ID")?.Value,
                    IssueDate = DateTime.Parse(doc.Root.Element(ns + "IssueDate")?.Value),
                    SupplierName = doc.Root.Element(ns + "AccountingSupplierParty")?.Element(ns + "Party")?.Element(ns + "PartyName")?.Element(ns + "Name")?.Value,
                    SupplierICO = doc.Root.Element(ns + "AccountingSupplierParty")?.Element(ns + "Party")?.Element(ns + "PartyIdentification")?.Element(ns + "ID")?.Value,
                    CustomerName = doc.Root.Element(ns + "AccountingCustomerParty")?.Element(ns + "Party")?.Element(ns + "PartyName")?.Element(ns + "Name")?.Value,
                    CustomerICO = doc.Root.Element(ns + "AccountingCustomerParty")?.Element(ns + "Party")?.Element(ns + "PartyIdentification")?.Element(ns + "ID")?.Value,
                };

                // Načtení všech řádků
                var lines = doc.Root.Element(ns + "InvoiceLines")?.Elements(ns + "InvoiceLine");

                if (lines != null)
                {
                    foreach (var line in lines)
                    {
                        invoice.Items.Add(new InvoiceItem
                        {
                            Description = line.Element(ns + "Item")?.Element(ns + "Description")?.Value,
                            Quantity = decimal.Parse(line.Element(ns + "InvoicedQuantity")?.Value, CultureInfo.InvariantCulture),
                            UnitPrice = decimal.Parse(line.Element(ns + "UnitPrice")?.Value, CultureInfo.InvariantCulture)
                        });
                    }
                }

                return invoice;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return null;
            }
        }
    }
}