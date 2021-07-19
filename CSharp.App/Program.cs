
using CSharp.Domain;
using FullStack.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.App
{
    class Program
    {
        private static readonly FullStackDbContext _context = new FullStackDbContext();
        static void Main(string[] args)
        {

            //var invoices = new InvoiceRepository();
            //for (int i = 1; i <= 12; i++)
            //{
            //    var inv = invoices.Retrieve(i);
            //    Console.WriteLine(inv);
            //    Console.WriteLine("=====================================================================================\n");
            //}
            InsertMonthOneInvoice(1);
            InsertMonthTwoInvoice(2);
            InsertMonthThreeInvoice(3);
            InsertMonthFourInvoice(4);
            InsertMonthFiveInvoice(5);
            InsertMonthSixInvoice(6);
            InsertMonthSevenInvoice(7);
            InsertMonthEightInvoice(8);
            InsertMonthNineInvoice(9);
            InsertMonthTenInvoice(10);
            InsertMonthElevenInvoice(11);
            InsertMonthTwelveInvoice(12);

            Console.WriteLine("\nApp is running....press any key to exit");
            Console.ReadLine();

        }

        private static void InsertMonthOneInvoice(int invoiceId)
        {
            
            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invOne = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(1),
                InvoiceReferenceNumber = "INV001",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(1),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>()
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 60m,
                        RatePerHour = 150m,
                        Description = "Analysis and Planning, defining use cases and capturing detailed functional requirements.",
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 8m,
                        RatePerHour = 80m,
                        Description = "Sketch Your App Idea, Sketch out your app idea with pen and paper.",
                    }
                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invOne);
            _context.SaveChanges();
        }

        private static void InsertMonthTwoInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invTwo = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(2),
                InvoiceReferenceNumber = "INV002",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(2),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 40m,
                        RatePerHour = 100m,
                        Description = "UI / UX Design. Creating Mockups of the app."
                    },

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invTwo);
            _context.SaveChanges();
        }

        private static void InsertMonthThreeInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invThree = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(3),
                InvoiceReferenceNumber = "INV003",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(3),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 24m,
                        RatePerHour = 250m,
                        Description = "Build Your App Landing Page",
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 120m,
                        RatePerHour = 200m,
                        Description = "Prototype",
                    }
                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invThree);
            _context.SaveChanges();
        }

        private static void InsertMonthFourInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invFour = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(4),
                InvoiceReferenceNumber = "INV004",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(4),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 240m,
                        RatePerHour = 350m,
                        Description = "Back-End/Server Technology",
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 60m,
                        RatePerHour = 180m,
                        Description = "API development",
                    }
                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invFour);
            _context.SaveChanges();
        }

        private static void InsertMonthFiveInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invFive = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(5),
                InvoiceReferenceNumber = "INV005",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(5),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 160m,
                        RatePerHour = 250m,
                        Description = "Mobile App Front-End development",
                    },

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invFive);
            _context.SaveChanges();
        }

        private static void InsertMonthSixInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invSix = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(6),
                InvoiceReferenceNumber = "INV006",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(6),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 45m,
                        RatePerHour = 120m,
                        Description = "User Experience Testing.",
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 60m,
                        RatePerHour = 100m,
                        Description = "Functional Testing",
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 50m,
                        RatePerHour = 170m,
                        Description = "Performance Testing",
                    }

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invSix);
            _context.SaveChanges();
        }

        private static void InsertMonthSevenInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invSeven = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(7),
                InvoiceReferenceNumber = "INV007",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(7),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 80m,
                        RatePerHour = 150m,
                        Description = "Security Testing."
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 100m,
                        RatePerHour = 200m,
                        Description = "Device and Platform Testing",
                    },

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invSeven);
            _context.SaveChanges();
        }

        private static void InsertMonthEightInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invEight = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(8),
                InvoiceReferenceNumber = "INV008",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(8),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 16m,
                        RatePerHour = 150m,
                        Description = "Deployment & Support",
                    },

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invEight);
            _context.SaveChanges();
        }
        private static void InsertMonthNineInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invNine = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(9),
                InvoiceReferenceNumber = "INV009",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(9),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                    {
                        new FullStack.Data.Entities.InvoiceItem
                        {
                            HoursWorked = 70m,
                            RatePerHour = 200m,
                            Description = "Bug fixing.",
                        },

                        new FullStack.Data.Entities.InvoiceItem
                        {
                            HoursWorked = 4m,
                            RatePerHour = 60m,
                            Description = "Testing fixed bugs.",
                        },

                    },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invNine);
            _context.SaveChanges();
        }

        private static void InsertMonthTenInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invTen = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(10),
                InvoiceReferenceNumber = "INV0010",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(10),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 60m,
                        RatePerHour = 150m,
                        Description = "Adding the infinit scroll and refresh feature",
                    },

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invTen);
            _context.SaveChanges();
        }

        private static void InsertMonthElevenInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invEleven = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(11),
                InvoiceReferenceNumber = "INV0011",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(11),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 5m,
                        RatePerHour = 120m,
                        Description = "Attending to technical issues.",
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 40m,
                        RatePerHour = 60m,
                        Description = "Market the app to reach the right people.",
                    },

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invEleven);
            _context.SaveChanges();
        }

        private static void InsertMonthTwelveInvoice(int invoiceId)
        {

            var invoiceItemList = new List<InvoiceItem>();
            var invoice = new Invoice(invoiceId, invoiceItemList);
            var invTwelve = new FullStack.Data.Entities.Invoice
            {
                InvoiceDate = invoice.CalculateInvoiceDate(11),
                InvoiceReferenceNumber = "INV0012",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(11),
                InvoiceItems = new List<FullStack.Data.Entities.InvoiceItem>
                {
                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 240m,
                        RatePerHour = 150m,
                        Description = "App maintenance.",
                    },

                    new FullStack.Data.Entities.InvoiceItem
                    {
                        HoursWorked = 80m,
                        RatePerHour = 85m,
                        Description = "Improving the app with user feedback.",
                    },

                },
                TotalInvoiceAmount = invoice.TotalInvoiceAmount
            };
            _context.Invoices.Add(invTwelve);
            _context.SaveChanges();
        }
    }
}

