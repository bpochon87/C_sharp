using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    public abstract class Person
    {
        // Declaring properties of class Person.
        public string firstName;
        public string lastName;

        // Declaring an abstract class method.
        public abstract void SayName();
    }
}
