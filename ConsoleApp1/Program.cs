using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Form");

            // Getting input from user and assigning it to an integer.
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);

            // Getting input from user and assigning it to a boolean.
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" for YES or \"false\" for NO.");
            string dui = Console.ReadLine();
            bool userDui = Convert.ToBoolean(dui);

            // Getting input from user and assigning it to an integer.
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int userSpeedingTickets = Convert.ToInt32(speedingTickets);

            // Printing the age, DUI status, and speeding tickets of the user.
            Console.WriteLine("Your age: " + userAge);
            Console.WriteLine("DUI status: " + userDui);
            Console.WriteLine("Speeding tickets: " + userSpeedingTickets + "\n");

            // If else loop to check for qualifying or disqualifying conditions with resulting, respective text printed
            // to screen.
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
