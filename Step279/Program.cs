using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step279
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int wholeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a decimal number: ");
            double decimalNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter one last number: ");
            string userString = Console.ReadLine();

            Math calculate = new Math();

            Console.WriteLine($"{wholeNumber} added to 1000 is {calculate.Add(wholeNumber)},\n" +
                $"{decimalNumber} added to 565 is {calculate.Add(decimalNumber)},\n" +
                $"{userString} added to 500 is {calculate.Add(userString)}.");

            Console.ReadLine();
        }
    }
}
