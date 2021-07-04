using System;
using System.Collections.Generic;

namespace CSharp.Domain
{
    public class Invoice
    {
        private const string Format = " Invoice Date: {0}\n Invoice Reference Number: {1}\n Invoice Due Date: {2}\n Total Invoice Amount: R{3}";                                     
        public Invoice()
        { 
        }
        public Invoice(int invoiceId)
        {
            InvoiceId = invoiceId;
            InvoiceItems = new List<InvoiceItem>();
        }

        public int InvoiceId { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public string InvoiceReferenceNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
        public decimal TotalInvoiceAmount { get; set; }

        /// <summary>
        /// Calculate the invoice date dive the month
        /// </summary>
        /// <param name="Month"></param>
        public DateTime CalculateInvoiceDate(int Month)
        {
            var ThisYear = DateTimeOffset.UtcNow.Year;
            var DaysInMonth = DateTime.DaysInMonth(ThisYear, Month);
            var InvoiceDate = new DateTime(ThisYear, Month, DaysInMonth);
            return InvoiceDate;
            //Console.WriteLine("Invoice Date: " + InvoiceDate);
        }

        /// <summary>
        /// Calculate the invoice due date given the month
        /// </summary>
        /// <param name="nextMont"></param>
        public DateTime CalculateInvoiceDueDate(int Month) 
        {
            var ThisYear = DateTimeOffset.UtcNow.Year;
            var DaysInNextMont = DateTime.DaysInMonth(ThisYear, Month);
            var InvoiceDueDate = new DateTime(ThisYear, Month, DaysInNextMont).AddDays(1).AddSeconds(-1);
            return InvoiceDueDate;
            //Console.WriteLine("Invoice Due Date: " + InvoiceDueDate);

        }
        
        /// <summary>
        /// Override toString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(Format, InvoiceDate, InvoiceReferenceNumber, InvoiceDueDate, TotalInvoiceAmount);
        }
        /// <summary>
        /// Validation
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (InvoiceReferenceNumber == null) isValid = false;
            if (TotalInvoiceAmount <= 0) isValid = false;

            return isValid;
        }

    }
}
