using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceRepository
    {
        
        public InvoiceRepository()
        {
            InvoiceItemRepository = new InvoiceItemReposetory();
        }
        public InvoiceItemReposetory InvoiceItemRepository { get; set; }
        public Invoice Retrieve(int invoiceId)
        {
            var invoiceItem = new InvoiceItem();
            Invoice invoice = new Invoice();

            if (invoiceId == 1) 
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV001";
                invoice.InvoiceItems = InvoiceItemRepository.MonthOneInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 2)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(1).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV002";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(2);
                invoice.InvoiceItems = InvoiceItemRepository.MonthTwoInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 3)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(2).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV003";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(3);
                invoice.InvoiceItems = InvoiceItemRepository.MonthThreeInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 4)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(3).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV004";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(4);
                invoice.InvoiceItems = InvoiceItemRepository.MonthFourInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 5)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(4).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV005";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(5);
                invoice.InvoiceItems = InvoiceItemRepository.MonthFiveInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 6)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(5).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV006";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(6);
                invoice.InvoiceItems = InvoiceItemRepository.MonthSixInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 7)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(6).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV007";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(7);
                invoice.InvoiceItems = InvoiceItemRepository.MonthSevenInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount(); 
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 8)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(7).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV008";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(8);
                invoice.InvoiceItems = InvoiceItemRepository.MonthEightInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 9)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(8).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV009";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(9);
                invoice.InvoiceItems = InvoiceItemRepository.MonthNineInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 10)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(9).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV010";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(10);
                invoice.InvoiceItems = InvoiceItemRepository.MonthTenInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 11)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(10).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV011";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(11);
                invoice.InvoiceItems = InvoiceItemRepository.MonthElevenInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }

            if (invoiceId == 12)
            {
                invoice.InvoiceDate = invoice.CalculateInvoiceDate(DateTimeOffset.UtcNow.Month).AddMonths(11).AddDays(-5);
                invoice.InvoiceReferenceNumber = "INV012";
                invoice.InvoiceDueDate = invoice.CalculateInvoiceDueDate(DateTimeOffset.UtcNow.Month).AddMonths(12);
                invoice.InvoiceItems = InvoiceItemRepository.MonthTwelveInvoiceItems().ToList();
                invoice.TotalInvoiceAmount = invoiceItem.CalculateTotalInvoiceAmount();
                Console.WriteLine(invoice);
                Console.WriteLine("==================================================================================\n");
            }
            return invoice;
        }

    }

}
