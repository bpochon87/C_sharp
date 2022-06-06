using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step331
{
    class Program
    {
        public struct Number
        {
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            Number newNumber = new Number();
            newNumber.Amount = (decimal)6900.35832;
            Console.WriteLine($"Amount's new value is {newNumber.Amount}.");
            Console.ReadLine();

        }
    }
}
