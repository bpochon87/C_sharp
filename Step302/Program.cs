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
            var employee1 = new Employee();

            // Initializing and instantiating new object of class 'Employee' with type 'IQuittable'.
            IQuittable quitPerson = new Employee();

            // Setting 'Employee' object properties.
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // Setting 'Employee1' object properties.
            employee1.firstName = "Brady";
            employee1.lastName = "Pochon";

            // Calling 'SayName' method from 'Employee' class (inherited from abstract 'Person' class).
            employee.SayName();

            // Calling 'Quit' method from 'IQuittable' interface.
            employee1.Quit(employee1);

            // Calling the 'Quit' interface and passing in the argument created above from 'Employee' class, employee.
            employee.Quit(employee);
            Console.ReadLine();
        }
    }
}
