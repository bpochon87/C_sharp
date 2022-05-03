using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step324
{
    class Program
    {
        public enum WeekDays
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main()
        {
            // Get current day of the week from user.
            Console.WriteLine("Please enter the current day of the week:");
            string userDay = Console.ReadLine().ToLower();

            // Creating variable of type 'WeekDays'.
            WeekDays getDayOfWeek;

            // Setting variable to 'TryParse' method which returns true or false if parameter ('userDay') is in our 'Enum'
            // objects 'getDayOfWeek'.
            bool checkParse = Enum.TryParse(userDay, out getDayOfWeek);

            // If 'userDay' is a day of the week, print following to console.
            if (checkParse == true)
            {
                Console.WriteLine($"Indeed, {userDay} is a day of the week.");
            }
            // If 'userDay' is not a day of the week, reprompt for legitimate input.
            else
            {
                Console.WriteLine($"{userDay} is not a day of the week. Please enter an actual day of the week.\n");
                Main();
            }
            Console.ReadLine();           
        }
    }
}
