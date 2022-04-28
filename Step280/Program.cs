using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get user input for first number.
            Console.WriteLine("Enter a number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            // Instantiating new object of class 'Math' so it's available to 'try/catch' block.
            Math calculate = new Math();

            // Execute 'try' if a second number is entered.
            try
            {
                Console.WriteLine("Enter another number or press enter if no number is desired: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{numberOne} + {numberTwo} + 500 = {calculate.Add(numberOne, numberTwo)}");
            }

            // Execute 'catch' if any exception occurs. We are wanting to catch a blank entry here.
            catch (Exception ex)
            {
                Console.WriteLine($"{numberOne} + 500 = {calculate.Add(numberOne)}");
            }
            Console.ReadLine();
        }
    }
}
