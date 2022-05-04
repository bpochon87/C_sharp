using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step337
{
    class Program
    {
        static void Main()
        {
            // Creating list of 'Employee' objects.
            List<Employee> employees = new List<Employee>
            {
                new Employee { ID = 1, firstName = "Brady", lastName = "Pochon" },
                new Employee { ID = 2, firstName = "Jimmy", lastName = "Neutron" },
                new Employee { ID = 3, firstName = "Dave", lastName = "Attell" },
                new Employee { ID = 4, firstName = "Jeremy", lastName = "Smith" },
                new Employee { ID = 5, firstName = "Joe", lastName = "Burrows" },
                new Employee { ID = 6, firstName = "Kelli", lastName = "Smith" },
                new Employee { ID = 7, firstName = "Corallis", lastName = "Vintage" },
                new Employee { ID = 8, firstName = "Hugh", lastName = "Jackman" },
                new Employee { ID = 9, firstName = "Joe", lastName = "Namath" },
                new Employee { ID = 10, firstName = "Robert", lastName = "Cone" }
            };

            List<Employee> joesOnly = new List<Employee>();
            // Iterating through list via a for loop and finding objects with 'firstName' equal to 'Joe'.
            foreach (Employee employee in employees)
            {
                // One any 'Joes' are found, they are added to our 'joesOnly' list.
                if (employee.firstName == "Joe")
                {
                    joesOnly.Add(employee);
                }
            }
            Console.WriteLine(joesOnly[0]);
            Console.ReadLine();

            // Iterating through list via a Lambda expression to find objects containing 'firstName' 'Joe'.
            
        }
    }
}
