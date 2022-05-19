using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallengeSubmission
{
    class Program
    {
        static void Main()
        {
            // Whenever using Context, we must wrap in 'using' statement so when it's done,
            // its resources are freed.
            using (var db = new StudentContext())
            {
                var student = new Student()
                {
                    StudentID = 1,
                    StudentFullName = "Brady Pochon",
                    Age = 35,
                    GPA = 3.92M, // M tells compiler that 3.92 is decimal.
                    GradeLevel = 14,
                };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Press any key to exit....");
                Console.ReadKey();
            }
        }
    }
}
