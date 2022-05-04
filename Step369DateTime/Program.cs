using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step369DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting current time to variable.
            var currentTime = DateTime.Now;

            Console.WriteLine($"The current time is {currentTime}.\n");
            Console.WriteLine("Now, please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Assigning variable to 'userNumber' hours plus 'currentTime' hours.
            DateTime futureTime = currentTime.AddHours(userNumber);
            Console.WriteLine($"\nIn {userNumber} hours it will be {futureTime}.");
            Console.ReadLine();
        }
    }
}
