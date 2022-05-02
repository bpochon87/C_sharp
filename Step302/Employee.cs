using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    public class Employee : Person, IQuittable
    {
        // Inherited from abstract class 'Person', the method 'SayName' must be defined in this class 'Employee'.
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // 'Quit' is from the 'IQuittable' interface and is being defined and implemented here in the 'Employee' class.
        public void Quit(Employee employee)
        {
            Console.WriteLine($"{firstName} {lastName} has quit within the past ten days.");
        }
    }
}
