using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathematicalOperations
    {
        // Addition method.
        public int Add(int userNumber)
        {
            int sum = userNumber + 10;
            return sum;
        }

        // Double (decimal) addition method.
        public int Add(double userDecimal)
        {
            double sum = userDecimal + 624.3;
            return (int)sum;
        }

        // Multiplication method.
        public int Add(string userString)
        {
            int userInteger = Convert.ToInt32(userString);
            int sum = userInteger + 23850;
            return sum;
        }
    }
}