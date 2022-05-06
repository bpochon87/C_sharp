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

            // Creating an empty list.
            List<Employee> joesOnly = new List<Employee>();
            // Iterating through list via a for loop and finding objects with 'firstName' equal to 'Joe'.
            foreach (Employee employee in employees)
            {
                // 'if' condition to find 'Employee' objects with 'firstName' property equal to 'Joe'.
                if (employee.firstName == "Joe")
                {
                    // Adding 'Employee' objects that meet the above condition to empty list.
                    joesOnly.Add(employee);
                    Console.WriteLine(employee.ID + " " + employee.firstName + " " + employee.lastName);
                }
            }

            // Creating an empty list.
            List<Employee> joesOnly1 = new List<Employee>();
            // Lambda expression iterating through employees list and grabbing all 'Employee' objects with 'firstName' equal to 'Joe'.
            joesOnly1 = employees.FindAll(x => x.firstName == "Joe");

            // Loop iterating through 'joesOnly1' list and print each list object.
            foreach (Employee joe in joesOnly1)
            {
                Console.WriteLine(joe.ID + " " + joe.firstName + " " + joe.lastName);
            }

            // Creating an empty list.
            List<Employee> idGreaterThan5 = new List<Employee>();
            // Lambda expression iterating through 'employees' list and grabbing all 'Employee' objects with 'ID' greater than 5.
            idGreaterThan5 = employees.FindAll(x => x.ID > 5);

            // Loop iterating through 'idGreaterThan5' list and print each list object.
            foreach (Employee joe in idGreaterThan5)
            {
                Console.WriteLine(joe.ID + " " + joe.firstName + " " + joe.lastName);
            }

            Console.ReadLine();
        }
    }
}
