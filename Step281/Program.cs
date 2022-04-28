using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating object of class 'Math'.
            Math calculate = new Math();

            // Passing two integers into the 'Add' method of 'Math' class.
            calculate.Add(55, 100);

            // Passing two integers via the named parameters of the 'Add' method in the 'Math' class.
            calculate.Add(numberTwo: 500, numberOne: 500);

            Console.ReadLine();
        }
    }
}
