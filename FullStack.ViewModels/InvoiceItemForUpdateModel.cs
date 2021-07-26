using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FullStack.ViewModels
{
    public class InvoiceItemForUpdateModel: InvoiceItemForManipulationModel
    {  
        public override decimal HoursWorked { get => base.HoursWorked; set => base.HoursWorked = value; }
        public override decimal RatePerHour { get => base.RatePerHour; set => base.RatePerHour = value; }

        [Required(ErrorMessage = "You should fill out a description.")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
