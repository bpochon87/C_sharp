using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step279
{
    public class Math
    {
        // Addition method.
        public int Add(int wholeNumber)
        {
            int sum = 1000 + wholeNumber;
            return sum;
        }

        // Addition method with decimal.
        public double Add(double decimalNumber)
        {
            int number = Convert.ToInt32(decimalNumber);
            double sum = 565 + number;
            return sum;
        }

        // Addition method with string.
        public int Add(string userString)
        {
            int userNumber = Convert.ToInt32(userString);
            int sum = 500 + userNumber;
            return sum;
        }
    }
}
