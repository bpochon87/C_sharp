using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313
{
    public class Employee
    {
        // Declaring class 'Employee' properties.
        public string firstName;
        public string lastName;
        public int ID;

        // Overloading the comparison operator. 
        public static bool operator == (Employee employee1, Employee employee2)
        {
            bool status = false;
            if (employee1.ID == employee2.ID)
            {
                status = true;
            }
            return status;
        }

        // Because the == operator is used, the user-defined != comparison must also be defined.
        public static bool operator != (Employee employee1, Employee employee2)
        {
            bool status = false;
            if (employee1.ID != employee2.ID)
            {
                status = true;
            }
            return status;
        }
    }
}
