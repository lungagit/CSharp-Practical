using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.ViewModels
{
    public class InvoiceItemModel
    {
        public int Id { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal RatePerHour { get; set; }
        public string Description { get; set; }
        public int InvoiceId { get; set; }
    }
}
