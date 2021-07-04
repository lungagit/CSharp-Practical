using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceItem
    {
        private const string Format = "\n Hours worked: {0}\n Rate per hour: {1}\n Description: {2}\n";

        public InvoiceItem()
        {
        }

        public InvoiceItem(int invoiceItemId)
        {
            InvoiceItemId = invoiceItemId;           
        }

        public int InvoiceItemId { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal RatePerHour { get; set; }
        public string Description { get; set; }
        public decimal CalculateTotalInvoiceAmount()
        {
            return HoursWorked * RatePerHour;
        }
        public override string ToString()
        {
            return string.Format(Format, HoursWorked, RatePerHour, Description);
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

            return isValid;
        }
    }
}
