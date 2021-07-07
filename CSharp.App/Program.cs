using CSharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Invoices = new InvoiceRepository();
            for (int i = 1; i <= 12; i++)
            {
                var inv = Invoices.Retrieve(i, i);
                Console.WriteLine(inv);
                Console.WriteLine("=====================================================================================\n");
            }

            Console.WriteLine("\nApp is running....press any key to exit");
            Console.ReadLine();
            
        }
        
    }
}

