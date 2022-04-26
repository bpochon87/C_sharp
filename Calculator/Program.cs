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
            Console.WriteLine("Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Instantiating new object of 'MathetmaticalOperations' class.
            MathematicalOperations calculate = new MathematicalOperations();
            Console.WriteLine(userNumber + " added to ten: " + calculate.Add(userNumber) + "\n" +
                userNumber + " with ten subtracted from it: " + calculate.Subtract(userNumber) + "\n" +
                userNumber + " multiplied by 50: " + calculate.Multiply(userNumber) + ".");
            Console.ReadLine();
        }
    }
}
