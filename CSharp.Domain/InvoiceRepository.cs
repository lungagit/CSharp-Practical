using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceRepository
    {

        public InvoiceRepository()
        {
            InvoiceItemRepository = new InvoiceItemRepository();
        }
        public InvoiceItemRepository InvoiceItemRepository { get; set; }
        public Invoice Retrieve(int invoiceId)
        {           
            var invoiceItemList = new List<InvoiceItem>();
            Invoice invoice = new Invoice(invoiceId, invoiceItemList);

            invoice.InvoiceDate = invoice.CalculateInvoiceDate(invoiceId);
            invoice.InvoiceReferenceNumber = "INV00" + invoiceId.ToString();
            invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(invoiceId);
            invoice.InvoiceItems = InvoiceItemRepository.RetrieveInvoiceItems(invoiceId).ToList();
             
            return invoice;
        }

    }

}
