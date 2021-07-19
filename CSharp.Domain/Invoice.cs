using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Domain
{
    public class Invoice
    {
        public Invoice(int invoiceId, List<InvoiceItem> invoiceItems)
        {
            Id = invoiceId;
            InvoiceItems = invoiceItems;
            this.InvoiceDate = this.CalculateInvoiceDate(invoiceId);
            this.InvoiceDueDate = this.CalculateInvoiceDueDate(invoiceId);
        }

        public int Id { get; set; }
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
        public DateTime CalculateInvoiceDate(int invoiceId)
        {
            var thisYear = DateTimeOffset.UtcNow.Year;
            var thisMonth = DateTimeOffset.UtcNow.Month;
            var daysInMonth = DateTime.DaysInMonth(thisYear, thisMonth);
            var lastDayOfMonth = new DateTime(thisYear, thisMonth, daysInMonth);
            var invoiceDate = lastDayOfMonth.AddMonths(invoiceId - 1).AddDays(-5);
            return invoiceDate;
        }

        /// <summary>
        /// Calculate the invoice due date given the month
        /// </summary>
        /// <param name="month"></param>
        public DateTime CalculateInvoiceDueDate(int invoiceId) 
        {
            var thisYear = DateTimeOffset.UtcNow.Year;
            var thisMonth = DateTimeOffset.UtcNow.Month;
            var daysInMonth = DateTime.DaysInMonth(thisYear, thisMonth);
            var lastDayOfMonth = new DateTime(thisYear,thisMonth, daysInMonth).AddDays(1).AddSeconds(-1);
            var invoiceDueDate = lastDayOfMonth.AddMonths(invoiceId);
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
