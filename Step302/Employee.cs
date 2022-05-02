using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    public class Employee : Person
    {
        // Inherited from abstract class 'Person', the method 'SayName' must be defined in this class 'Employee'.
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
