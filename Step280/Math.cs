using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280
{
    public class Math
    {
        // Addition method with 1 required parameter and one optional.
        public int Add(int numberOne, int numberTwo = 0)
        {
            int sum = numberOne + numberTwo + 500;
            return sum;
        }
    }
}
