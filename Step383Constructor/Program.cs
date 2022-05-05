using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step383Constructor
{
    class Program
    {
        // Only C# built-in types (sans System.Object) may be declared const. User-defined (classes, strructs, arrays) cannot be const.
        public const double Pi = 3.14159;

        static void Main()
        {            
            var student = new Student(1, "Brady", "Pochon", 14);
            Console.WriteLine($"Let's welcome {student.FirstName} {student.LastName} to grade {student.GradeLevel}!\n");
            Console.WriteLine($"Does {student.FirstName} know about {Pi}? Let's hope so!");
            Console.ReadLine();

        }
    }
}
