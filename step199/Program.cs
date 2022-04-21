using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Form");

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" for YES or \"false\" for NO.");
            string dui = Console.ReadLine();
            bool userDui = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int userSpeedingTickets = Convert.ToInt32(speedingTickets);

            Console.WriteLine("Your age: " + userAge);
            Console.WriteLine("DUI status: " + userDui);
            Console.WriteLine("Speeding tickets: " + userSpeedingTickets);

            if (userAge >= 15 && userDui == false && userSpeedingTickets <= 3)
            {
                Console.WriteLine("Congratulations! You qualify for auto insurance.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ooof! You're a bad driver!");
                Console.ReadLine();
            }




        }
    }
}
