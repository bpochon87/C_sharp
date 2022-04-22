using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class step222
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the directions below.");

            // Assigning user input to int variable.
            Console.WriteLine("What is the package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            // If loop to check if user input less than 50. If greater than 50, program exits.
            if (packageWeight > 50)
            {
                Console.WriteLine("We do not ship live animals via Package Express. Have a good day.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Assigning user input to int variable.
            Console.WriteLine("What is the package width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Assigning user input to int variable.
            Console.WriteLine("What is the package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            // Assigning user input to int variable.
            Console.WriteLine("What is the package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // If loop checking for previous three variables and if each is greater than 50.
            // If greater than 50, program exits.
            if (packageWidth > 50 || packageHeight > 50 || packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
                
            // Math operation to figure out cost.
            int packageCostQuote = (packageWeight * packageHeight * packageWidth * packageLength) / 100;

            // Cost printed for customer.
            Console.WriteLine("Your estimated total for shipping this package is $" + packageCostQuote);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
