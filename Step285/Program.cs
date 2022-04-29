using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285
{
    class Program
    {
        static void Main(string[] args)
        {
            Math calculate = new Math();

            // Get user input to pass into 'Math' class method 'Divide'.
            Console.WriteLine("Please enter a number: ");
            double passedData1 = Convert.ToDouble(Console.ReadLine());

            // Calling on 'Math' class 'Divide' method while passing in one parameter.
            // The 'out' parameter will allow a returned value from our 'Divide' method within 'Math' class.
            calculate.Divide(passedData1, out double quotient);
            Console.WriteLine($"{passedData1} divided by two is {quotient}.");
            Console.ReadLine();

        }
    }
}
