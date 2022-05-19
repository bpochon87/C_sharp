using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallengeSubmission
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFullName { get; set; }
        public int Age { get; set; }
        public decimal GPA { get; set; }
        public int GradeLevel { get; set; }
    }

    // Defining a derived context is necessary to represent a session with the dB.
    // This allows us to query and save data.
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
