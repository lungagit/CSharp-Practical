using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FullStack.Data.Entities
{
    public class Invoice
    {
        public Invoice()
        {
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public string InvoiceReferenceNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
        public decimal TotalInvoiceAmount { get; set; }

    }
}
