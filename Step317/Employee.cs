using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step317
{
    // The 'Employee' class is accepting a generic parameter (via <T>).
    public class Employee<T>
    {
        // A property of type 'List' that will handle generic types (via <T>).
        public List<T> Things = new List<T>();

    }
}
