using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step383Constructor
{
    public class Student
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int GradeLevel;
        
        // Constructor chaining instead of overloading via ': this.(field)'.

        public Student()
        {
        }

        public Student(int id)
            : this()
        {
            this.Id = id;
        }

        public Student(int id, string fName)
            : this(id)
        {
            this.FirstName = fName;
        }

        public Student(int id, string fName, string lName)
            : this(id, fName)
        {
            this.LastName = lName;
        }

        public Student(int id, string fName, string lName, int grade)
            : this(id, fName, lName)
        {
            this.GradeLevel = grade;
        }
    }
}
