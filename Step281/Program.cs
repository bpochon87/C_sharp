using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declaring and initializing our variables.
            int firstNumber = 500;
            int secondNumber = 100;

            // Instantiating an object 'operate' of class 'Math'.
            Math operate = new Math();

            // Calling upon 'Add' method within class 'Math' with object 'operate' while passing in our variables.
            operate.Add(firstNumber, secondNumber);
            Console.ReadLine();
        }
    }
}
