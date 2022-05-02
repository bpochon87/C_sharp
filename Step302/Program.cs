using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing and instantiating new object of class 'Employee'.
            var employee = new Employee();

            // Setting 'Employee' class properties.
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // Calling 'SayName' method from 'Employee' class (inherited from abstract 'Person' class).
            employee.SayName();
            Console.ReadLine();
        }
    }
}
