using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302
{
    // Like an abstract base class that must have all its members implemented when inherited.
    interface IQuittable
    {
        // Declaring a method and its parameters.
        // Implementation and definition will happen in classes that inherit the 'IQuittable' interface.
        void Quit(Employee employee);
    }
}
