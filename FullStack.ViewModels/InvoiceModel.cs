using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.ViewModels
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public string InvoiceReferenceNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItemModel> InvoiceItems { get; set; } = new List<InvoiceItemModel>();
        public decimal TotalInvoiceAmount { get; set; }
    }
}
