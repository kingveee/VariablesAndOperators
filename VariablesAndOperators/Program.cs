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
            int age = 65;
            string why = "because I said so";
            char firstInitial = 'L';

            //floating point types
            float floatNumber = 2.164403304897294849383961032f;
            Console.WriteLine(floatNumber);

            double doubleNumber = 2.164403304897294849383961032d;
            Console.WriteLine(doubleNumber);

            decimal decimalNumber = 2.164403304897294849383961032m;
            Console.WriteLine(decimalNumber);

            int jessicaAge = 23;
            int samAge = 47;
            Console.WriteLine(jessicaAge < samAge);




            Console.WriteLine("What is the name on the reservation?");
            string reserveName = Console.ReadLine();

            Console.WriteLine("How many people are in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            double amountEach = 13.53d;

            double totalBill = numberOfPeople * amountEach;
            Console.WriteLine("Reservation: " + reserveName);
            Console.WriteLine("Total Due: $" + totalBill);







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

            Console.WriteLine("Donated Ones");
            int ones = int.Parse(Console.ReadLine()) * 1;

            Console.WriteLine("Donated Fives");
            int fives = int.Parse(Console.ReadLine()) * 5;

            Console.WriteLine("Donated Tens");
            int tens = int.Parse(Console.ReadLine()) * 10;

            Console.WriteLine("Donated Twenties");
            int twenties = int.Parse(Console.ReadLine()) * 20;

            Console.WriteLine("Donated Fifties");
            int fifties = int.Parse(Console.ReadLine()) * 50;

            Console.WriteLine("Donated Hundreds");
            int hundereds = int.Parse(Console.ReadLine()) * 100;

            /* quaters may be "double" 25d */
            /* combine all for donation amount */

           









        }
    }
}
