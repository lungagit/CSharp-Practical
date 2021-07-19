using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceItemRepository
    {
        public IEnumerable<InvoiceItem> RetrieveInvoiceItems(int invoiceId)
        {
            var invoiceItemList = new List<InvoiceItem>();
            
            if (invoiceId == 1)
            {
                decimal ItemOneTotal, ItemTwoTotal;
                
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 60m,
                    RatePerHour = 150m,
                    Description = "Analysis and Planning, defining use cases and capturing detailed functional requirements.",
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 8m,
                    RatePerHour = 80m,
                    Description = "Sketch Your App Idea, Sketch out your app idea with pen and paper.",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
                invoiceItemList.Add(invoiceItem);               
            }
            

            if (invoiceId == 2)
            {
                decimal ItemOneTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 40m,
                    RatePerHour = 100m,
                    Description = "UI / UX Design. Creating Mockups of the app."
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal + "\n");

                return invoiceItemList;
            }

            if (invoiceId == 3)
            {
                decimal ItemOneTotal, ItemTwoTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 24m,
                    RatePerHour = 250m,
                    Description = "Build Your App Landing Page",
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 120m,
                    RatePerHour = 200m,
                    Description = "Prototype",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
                invoiceItemList.Add(invoiceItem);

            }

            if (invoiceId == 4)
            {
                decimal ItemOneTotal, ItemTwoTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 240m,
                    RatePerHour = 350m,
                    Description = "Back-End/Server Technology",
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 60m,
                    RatePerHour = 180m,
                    Description = "API development",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
                invoiceItemList.Add(invoiceItem);

            }

            if (invoiceId == 5)
            {               
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 160m,
                    RatePerHour = 250m,
                    Description = "Mobile App Front-End development",
                };

                Console.WriteLine(" Invoice Items:");
                Console.WriteLine(invoiceItem);
                invoiceItemList.Add(invoiceItem);

            }

            if (invoiceId == 6)
            {
                decimal ItemOneTotal, ItemTwoTotal, ItemThreeTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 45m,
                    RatePerHour = 120m,
                    Description = "User Experience Testing.",
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 60m,
                    RatePerHour = 100m,
                    Description = "Functional Testing",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal);
                invoiceItemList.Add(invoiceItem);

                invoiceItem = new InvoiceItem(3)
                {
                    HoursWorked = 50m,
                    RatePerHour = 170m,
                    Description = "Performance Testing",
                };

                ItemThreeTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemThreeTotal + "\n");
                invoiceItemList.Add(invoiceItem);

            }

            if (invoiceId == 7)
            {
                decimal ItemOneTotal, ItemTwoTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 80m,
                    RatePerHour = 150m,
                    Description = "Security Testing."
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 100m,
                    RatePerHour = 200m,
                    Description = "Device and Platform Testing",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
                invoiceItemList.Add(invoiceItem);
 
            }

            if (invoiceId == 8)
            {
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 16m,
                    RatePerHour = 150m,
                    Description = "Deployment & Support",
                };

                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);

            }

            if (invoiceId == 9)
            {
                decimal ItemOneTotal, ItemTwoTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 70m,
                    RatePerHour = 200m,
                    Description = "Bug fixing.",
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                invoiceItemList.Add(invoiceItem);
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 4m,
                    RatePerHour = 60m,
                    Description = "Testing fixed bugs.",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
                invoiceItemList.Add(invoiceItem);
 
            }

            if (invoiceId == 10)
            {
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 60m,
                    RatePerHour = 150m,
                    Description = "Adding the infinit scroll and refresh feature",
                };
                Console.WriteLine(" Invoice Items:");
                Console.WriteLine(invoiceItem);
                invoiceItemList.Add(invoiceItem);

            }

            if (invoiceId == 11)
            {
                decimal ItemOneTotal, ItemTwoTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 5m,
                    RatePerHour = 120m,
                    Description = "Attending to technical issues.",
                };

                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);
                invoiceItemList.Add(invoiceItem);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 40m,
                    RatePerHour = 60m,
                    Description = "Market the app to reach the right people.",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
                invoiceItemList.Add(invoiceItem);

            }

            if (invoiceId == 12)
            {
                decimal ItemOneTotal, ItemTwoTotal;
                InvoiceItem invoiceItem = new InvoiceItem(1)
                {
                    HoursWorked = 240m,
                    RatePerHour = 150m,
                    Description = "App maintenance.",
                };
                ItemOneTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(" Invoice Items:");
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemOneTotal);
                invoiceItemList.Add(invoiceItem);

                invoiceItem = new InvoiceItem(2)
                {
                    HoursWorked = 80m,
                    RatePerHour = 85m,
                    Description = "Improving the app with user feedback.",
                };

                ItemTwoTotal = invoiceItem.HoursWorked * invoiceItem.RatePerHour;
                Console.WriteLine(invoiceItem);
                Console.WriteLine(" Total: R" + ItemTwoTotal + "\n");
                invoiceItemList.Add(invoiceItem);
               
            }

            return invoiceItemList;
        }
      
    }
}
