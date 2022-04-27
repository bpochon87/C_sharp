using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input as integer.
            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Get user input as float.
            Console.WriteLine("Now enter a decimal: ");
            double userDecimal = Convert.ToDouble(Console.ReadLine());

            // Get user input as string.
            Console.WriteLine("...and finally another number: ");
            string userString = Console.ReadLine();

            // Instantiating new object of 'MathetmaticalOperations' class.
            // 'calculate' is an instance of the class MathematicalOperations.
            MathematicalOperations calculate = new MathematicalOperations();

            // We are able to pass in user input to each method within the 'calculate' instance because we're
            // now able to access all of the attributes of class MathetmaticalOperations.
            Console.WriteLine($"{userNumber} added to ten is {calculate.Add(userNumber)}.");
            Console.WriteLine($"Your number as a decimal added to 624.3 is " + calculate.Add(userDecimal) + ".");
            Console.WriteLine($"{userString} added to 23850 is {calculate.Add(userString)}.");

            Console.ReadLine();
        }
    }
}
