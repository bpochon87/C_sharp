using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285
{
    public class Math
    {
        // This method accepts one argument and has one 'out' parameter.
        public void Divide(double passedData1, out double quotient)
        {
            quotient = passedData1 / 2;
        }

        // Although this method isn't being used, we could ask for another input from the user and, through overloading,
        // call this method instead of the above method.
        public void Divide(double passedData1, double passedData2, out double quotient)
        {
            quotient = passedData1 / passedData2;
        }
    }
    // This 'static class' is doing nothing but can act as a template for inherited classes.
    static class Mathmematician
    {
        public static string FirstName;
        public static string LastName;
        public static string AreaExpertise;
        public static string YearsExperience;
    }
}
