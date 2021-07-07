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
        public Invoice Retrieve(int invoiceId, int month)
        {
            month = DateTimeOffset.UtcNow.Month;
            var invoiceItemList = new List<InvoiceItem>();
            Invoice invoice = new Invoice(invoiceId, invoiceItemList, month);
            
            invoice.InvoiceDate = invoice.CalculateInvoiceDate(month).AddMonths(invoiceId - 1).AddDays(-5);
            invoice.InvoiceReferenceNumber = "INV00" + invoiceId.ToString();
            invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(invoiceId);
            invoice.InvoiceItems = InvoiceItemRepository.RetrieveInvoiceItems(invoiceId).ToList();
             
            return invoice;
        }

    }

}
