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

        // Subtraction method.
        public int Subtract(int userNumber)
        {
            int difference = userNumber - 10;
            return difference;
        }

        // Multiplication method.
        public int Multiply(int userNumber)
        {
            int product = userNumber * 50;
            return product;
        }
    }
}