using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathematicalOperations
    {
        // Addition method with required first parameter and optional second parameter.
        public int Add(int firstNumber, int secondNumber = 0)
        {
            int sum = 500 + firstNumber + secondNumber;
            return sum;
        }
    }
}