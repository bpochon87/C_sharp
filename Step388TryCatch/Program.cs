using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step388TryCatch
{
    class Program
    {
        static void Main()
        {
            // 'DateTime' struct for current time/day/month/year.
            DateTime now = DateTime.Now;
            // Accessing year from 'DateTime.Now'.
            int year = now.Year;
            int userAge;

            // Run this code if no exceptions are thrown.
            try
            {
                // 'do while' loop to bar zero and negative numbers.
                do
                {
                    Console.WriteLine("How old are you?");
                    userAge = Convert.ToInt32(Console.ReadLine());
                    // 'if' statement runs only with zero and negative numbers.
                    if (userAge <= 0)
                    {
                        Console.WriteLine("Please enter an age above zero.");
                    }
                }
                while (userAge <= 0);

                // Logic to calculate user's age.
                int yearUserBorn = year - userAge;
                Console.WriteLine($"You were born in {yearUserBorn}.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter digits with no decimals.");
                Console.ReadLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Main();
            }
            catch (Exception)
            {
                Console.WriteLine("Please re-enter your age.");
                Console.ReadLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Main();
            } 
        }
    }
}
