using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceItem
    {
        public InvoiceItem(int invoiceItemId)
        {
            Id = invoiceItemId;             
        }
        public int Id { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal RatePerHour { get; set; }
        public string Description { get; set; }
        public decimal TotalInvoiceItemAmount => Math.Round(HoursWorked * RatePerHour, 2);
        public override string ToString()
        {
            return string.Format("\n Hours worked: {0}\n Rate per hour: {1}\n Description: {2}\n", HoursWorked, RatePerHour, Description);
        }
        /// <summary>
        /// Validate Invoice items
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (HoursWorked <= 0) isValid = false;
            if (RatePerHour <= 0) isValid = false;
            if (TotalInvoiceItemAmount <= 0) isValid = false;

            return isValid;
        }
    }
}
