using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.ViewModels
{
    public class InvoiceItemForManipulationModel
    {
        public virtual decimal HoursWorked { get; set; }
        public virtual decimal RatePerHour { get; set; }
        public virtual string Description { get; set; }
    }
}
