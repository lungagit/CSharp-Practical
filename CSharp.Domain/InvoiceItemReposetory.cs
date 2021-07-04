using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceItemReposetory
    {
        public InvoiceItemReposetory()
        { 
        }
        public IEnumerable<InvoiceItem> MonthOneInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {
                
                HoursWorked = 60,
                RatePerHour = 150,
                Description = "Analysis and Planning, defining use cases and capturing detailed functional requirements.",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 8,
                RatePerHour = 80,
                Description = "Sketch Your App Idea, Sketch out your app idea with pen and paper.",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R"+ ItemTwoTotal + "\n");         
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal;
            Console.WriteLine(" Total Invoice Amount: "+ TotalInvoiceAmount +"\n");
            return invoiceItemList;
        }

        public IEnumerable<InvoiceItem> MonthTwoInvoiceItems()
        {
            decimal ItemOneTotal;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {
                HoursWorked = 40,
                RatePerHour = 100,
                Description = "UI / UX Design. Creating Mockups of the app."
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal + "\n");

            return invoiceItemList;
        }

        public IEnumerable<InvoiceItem> MonthThreeInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 24,
                RatePerHour = 250,
                Description = "Build Your App Landing Page",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 120,
                RatePerHour = 200,
                Description = "Prototype",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal;
            Console.WriteLine(" Total Invoice Amount: " + TotalInvoiceAmount + "\n");

            return invoiceItemList;
        }

        public IEnumerable<InvoiceItem> MonthFourInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 240,
                RatePerHour = 350,
                Description = "Back-End/Server Technology",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 60,
                RatePerHour = 180,
                Description = "API development",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal;
            Console.WriteLine(" Total Invoice Amount: " + TotalInvoiceAmount + "\n");

            return invoiceItemList;
        }

        public IEnumerable<InvoiceItem> MonthFiveInvoiceItems()
        {
            decimal ItemOneTotal;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 160,
                RatePerHour = 250,
                Description = "Mobile App Front-End development",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total Invoice Amount: R" + ItemOneTotal + "\n");

            return invoiceItemList;
        }
        public IEnumerable<InvoiceItem> MonthSixInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, ItemThreeTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 45,
                RatePerHour = 120,
                Description = "User Experience Testing.",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 60,
                RatePerHour = 100,
                Description = "Functional Testing",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemTwoTotal);
            invoiceItemList.Add(invoiceItem);

            invoiceItem = new InvoiceItem(3)
            {
                HoursWorked = 50,
                RatePerHour = 170,
                Description = "Performance Testing",
            };

            ItemThreeTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemThreeTotal + "\n");
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal + ItemThreeTotal;
            Console.WriteLine(" Total Invoice Amount: " + TotalInvoiceAmount + "\n");

            return invoiceItemList;
        }
        public IEnumerable<InvoiceItem> MonthSevenInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 80,
                RatePerHour = 150,
                Description = "Security Testing."
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 100,
                RatePerHour = 200,
                Description = "Device and Platform Testing",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal;
            Console.WriteLine(" Total Invoice Amount: " + TotalInvoiceAmount + "\n");

            return invoiceItemList;
        }
        public IEnumerable<InvoiceItem> MonthEightInvoiceItems()
        {
            decimal ItemOneTotal;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 16,
                RatePerHour = 150,
                Description = "Deployment & Support",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total Invoice Amount: R" + ItemOneTotal + "\n");

            return invoiceItemList;
        }
        public IEnumerable<InvoiceItem> MonthNineInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 70,
                RatePerHour = 200,
                Description = "Bug fixing.",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 4,
                RatePerHour = 60,
                Description = "Testing fixed bugs.",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal;
            Console.WriteLine(" Total Invoice Amount: " + TotalInvoiceAmount + "\n");

            return invoiceItemList;
        }
        public IEnumerable<InvoiceItem> MonthTenInvoiceItems()
        {
            decimal total;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 60,
                RatePerHour = 150,
                Description = "Adding the infinit scroll and refresh feature",
            };
            total = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            invoiceItemList.Add(invoiceItem);
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total Invoice Amount: R" + total + "\n");

            return invoiceItemList;
        }
        public IEnumerable<InvoiceItem> MonthElevenInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 5,
                RatePerHour = 120,
                Description = "Attending to technical issues.",
            };

            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);
            invoiceItemList.Add(invoiceItem);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 40,
                RatePerHour = 60,
                Description = "Market the app to reach the right people.",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal;
            Console.WriteLine(" Total Invoice Amount: " + TotalInvoiceAmount + "\n");
            
            return invoiceItemList;
        }
        public IEnumerable<InvoiceItem> MonthTwelveInvoiceItems()
        {
            decimal ItemOneTotal, ItemTwoTotal, TotalInvoiceAmount;
            var invoiceItemList = new List<InvoiceItem>();
            InvoiceItem invoiceItem = new InvoiceItem(1)
            {

                HoursWorked = 240,
                RatePerHour = 150,
                Description = "App maintenance.",
            };
            ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(" Invoice Items:");
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemOneTotal);
            invoiceItemList.Add(invoiceItem);

            invoiceItem = new InvoiceItem(2)
            {
                HoursWorked = 80,
                RatePerHour = 85,
                Description = "Improving the app with user feedback.",
            };

            ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
            Console.WriteLine(invoiceItem);
            Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
            invoiceItemList.Add(invoiceItem);
            TotalInvoiceAmount = ItemOneTotal + ItemTwoTotal;
            Console.WriteLine(" Total Invoice Amount: " + TotalInvoiceAmount + "\n");
            
            return invoiceItemList;
        }
    }
}
