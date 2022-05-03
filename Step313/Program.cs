using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing and instantiating objects of 'Employee' class.
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            // Assigning values to 'Employee' class properties.
            employee1.firstName = "Sara";
            employee2.firstName = "Brady";

            employee1.lastName = "Pochon";
            employee2.lastName = "Pochon";

            employee1.ID = 1;
            employee2.ID = 1;

            // Because the bool comparison operator '==' and '!=' were user-defined within the 'Employee' class, we are able to
            // compare two objects of the 'Employee' class on the 'ID' property.
            if (employee1 == employee2)
            {
                Console.WriteLine($"The ID number {employee1.ID} is assigned to {employee1.firstName} and {employee2.firstName}.");
            }
            else
            {
                Console.WriteLine($"{employee1.firstName} and {employee2.firstName} have unique IDs.");
            }
            Console.ReadLine();
        }
    }
}
