using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_292
{
    public class Person
    {
        // Declaring properties of class.
        public string FirstName;
        public string LastName;

        // Declaring and defining class method.
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
