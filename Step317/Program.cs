using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step317
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things.Add("Hello");

            Console.WriteLine(employee.Things);
            Console.ReadLine();
        }
    }
}
