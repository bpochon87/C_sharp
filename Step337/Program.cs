using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step337
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> employees = new List<string>()
            {
                "ID 1 - Brady Pochon",
                "ID 2 - Sara Pochon",
                "ID 3 - Ron Pochon",
                "ID 4 - Dale Dee Pochon",
                "ID 5 - Jeremy Smith",
                "ID 6 - Kelli Smith",
                "ID 7 - Joe Burrows",
                "ID 8 - Joe Stamm",
                "ID 9 - Jesus Rodriguez",
                "ID 10 - Osvaldo Marquez"
            };
            
            // 'foreach' loop iterating through list to find objects containing the string 'Joe'. Using lambda here as well.
            foreach (string employee in employees)
            {
                if (employee.Contains("Joe"))
                {
                    Console.WriteLine(employee);
                }
            }

            // Lambda expression to find any list objects containing the string 'Joe'.
            List<string> namedJoe = employees.FindAll(x => x.Contains("Joe"));
            foreach (string joe in namedJoe)
            {
                Console.WriteLine(joe);
            }

            Console.ReadLine();
        }
    }
}
