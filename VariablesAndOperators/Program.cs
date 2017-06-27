using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            

           

           



            // Problem 2 
            int completeCups = 7;
            int cupsUsed = 2;
        
            int cupsNeeded = (completeCups - cupsUsed);
            Console.WriteLine(cupsNeeded);
           
            //Problem 3
            int moneyAvailable = 40;
            int packageCost = 8;
            int packagePurchased = (moneyAvailable / packageCost);
            Console.WriteLine(packagePurchased);

            //Donation Tracker
            Console.WriteLine("Name of Donor");
            string donorName = Console.ReadLine();

            Console.WriteLine("Address of Donor");
            string donorAddress = Console.ReadLine();

            Console.WriteLine("Email of Donor");
            string donorEmail = Console.ReadLine();

            Console.WriteLine("Fiscal Year");
            string year = Console.ReadLine();

            



        }
    }
}
