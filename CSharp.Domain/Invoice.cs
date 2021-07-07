using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Domain
{
    public class Invoice
    {
        private int month;
        public Invoice(int invoiceId, List<InvoiceItem> invoiceItems, int month)
        {
            InvoiceId = invoiceId;
            this.month = month;
            InvoiceItems = invoiceItems;
            this.InvoiceDate = this.CalculateInvoiceDate(month);
        }

        public int InvoiceId { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public string InvoiceReferenceNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
        public decimal TotalInvoiceAmount
        {
            get 
            {
                return this.InvoiceItems.Sum(i => i.TotalInvoiceItemAmount);
            } 
        }

        /// <summary>
        /// Calculate the invoice date
        /// </summary>
        /// <param name="month"></param>
        public DateTime CalculateInvoiceDate(int month)
        {
            var ThisYear = DateTimeOffset.UtcNow.Year;
            var DaysInMonth = DateTime.DaysInMonth(ThisYear, month);
            var InvoiceDate = new DateTime(ThisYear, month, DaysInMonth);
            return InvoiceDate;
        }

        /// <summary>
        /// Calculate the invoice due date given the month
        /// </summary>
        /// <param name="month"></param>
        public DateTime CalculateInvoiceDueDate(int month) 
        {
            var thisYear = DateTimeOffset.UtcNow.Year;
            var daysInNextMont = DateTime.DaysInMonth(thisYear, month);
            var invoiceDueDate = new DateTime(thisYear, month, daysInNextMont).AddDays(1).AddSeconds(-1);
            return invoiceDueDate;
        }
        
        /// <summary>
        /// Override toString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(" Invoice Date: {0}\n Invoice Reference Number: {1}\n Invoice Due Date: {2}\n Total Invoice Amount: R{3}", InvoiceDate, InvoiceReferenceNumber, InvoiceDueDate, TotalInvoiceAmount);
        }
        /// <summary>
        /// Validation
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (InvoiceReferenceNumber == null) isValid = false;
            if (InvoiceReferenceNumber == "") isValid = false;

            return isValid;
        }

    }
}
