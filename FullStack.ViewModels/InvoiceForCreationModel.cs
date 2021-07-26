using FullStack.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.ViewModels
{
    public class InvoiceForCreationModel
    {
        public int Id { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public string InvoiceReferenceNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItemForCreationModel> InvoiceItems { get; set; } = new List<InvoiceItemForCreationModel>();
        public decimal TotalInvoiceAmount { get; set; }
    }
}
