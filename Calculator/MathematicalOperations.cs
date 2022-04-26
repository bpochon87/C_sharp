using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathematicalOperations
    {
        public MathematicalOperations(int userNumOne, int userNumTwo)
        {
            // Addition
            public static MathematicalOperations Add()
            {
                int sum = userNumOne + userNumTwo;
                return sum;
            }

            // Subtraction
            public static MathematicalOperations Subtract()
            {
                int difference = userNumOne - userNumTwo;
                return difference;
            }

            // Multiplication
            public static MathematicalOperations Multiply()
            {
                int product = userNumOne * userNumTwo;
                return product;
            }

            // Division
            public static MathematicalOperations Divide()
            {
                int quotient = userNumOne / userNumTwo;
                return quotient;
            }

        }

        public int UserNumOne { get; }
        public int UserNumTwo { get; }
    }
}
