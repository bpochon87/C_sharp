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
            int userNumOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");
            int userNumTwo = Convert.ToInt32(Console.ReadLine());

            // Instantiating new object of 'MathetmaticalOperations' class.
            MathematicalOperations calculate = new MathematicalOperations(userNumOne, userNumTwo);
        }
    }
}
