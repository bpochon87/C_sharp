using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step186
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // Getting user input for 'person 1' and assigning it to an integer.
            Console.WriteLine("Person 1: Please enter your hourly rate:");
            string oneHourlyRate = Console.ReadLine();
            int personOneHourlyRate = Convert.ToInt32(oneHourlyRate);

            // Getting user input for 'person 1' and assigning it to an integer.
            Console.WriteLine("Person 1: Please enter your hours worked per week:");
            string oneWeeklyHours = Console.ReadLine();
            int personOneWeeklyHours = Convert.ToInt32(oneWeeklyHours);

            // Getting user input for 'person 2' and assigning it to an integer.
            Console.WriteLine("Person 2: Please enter your hourly rate:");
            string twoHourlyRate = Console.ReadLine();
            int personTwoHourlyRate = Convert.ToInt32(twoHourlyRate);

            // Getting user input for 'person 2' and assigning it to an integer.
            Console.WriteLine("Person 2: Please enter your hours worked per week:");
            string twoWeeklyHours = Console.ReadLine();
            int personTwoWeeklyHours = Convert.ToInt32(twoWeeklyHours);

            // Calculating 'person 1' and 'person 2' annual salary.
            int personOneAnnualSalary = personOneHourlyRate * personOneWeeklyHours * 52;
            int personTwoAnnualSalary = personTwoHourlyRate * personTwoWeeklyHours * 52;

            // Printing to screen respective salaries of 'person 1' and 'person 2'.
            Console.WriteLine("Person 1: Your annual salary:\n" + personOneAnnualSalary + "\n");
            Console.WriteLine("Person 2: Your annual salary:\n" + personTwoAnnualSalary + "\n");

            // Creating boolean in response to 'person 1' salary being greater than 'person 2'.
            Console.WriteLine("Does person 1 make more moolah than person 2?\n");
            bool makesMoreSalary = personOneAnnualSalary > personTwoAnnualSalary;
            Console.WriteLine("This statement is " + makesMoreSalary + "\n");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
