using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FullStack.Data.Entities
{
    public class InvoiceItem
    {
        public InvoiceItem()
        {          
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal RatePerHour { get; set; }
        public string Description { get; set; }
        public Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }

    }
}
