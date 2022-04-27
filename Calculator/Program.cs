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
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            // Get optional second user input.
            Console.WriteLine("Please enter another number or enter zero if no whole number is desired: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            // Instantiating new object of 'MathetmaticalOperations' class.
            // 'calculate' is an instance of the class MathematicalOperations.
            MathematicalOperations calculate = new MathematicalOperations();

            // We are able to pass in user input to each method within the 'calculate' instance because we're
            // now able to access all of the attributes of class MathetmaticalOperations.
            Console.WriteLine($"{firstNumber} and {secondNumber} added to 500 is {calculate.Add(firstNumber, secondNumber)}.");

            Console.ReadLine();
        }
    }
}
