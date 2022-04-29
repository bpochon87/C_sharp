using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_292
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initializing and instantiating object of class 'Employee'.
            var employee = new Employee();

            // Setting 'Employee' class properties. 
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Calling 'Employee' class method which is inherited from base class 'Person'.
            employee.SayName();
            Console.ReadLine();
        }
    }
}
