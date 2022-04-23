using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Practice
    {
        static void Main()
        {
            Console.WriteLine("Guess a number!");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62! Wrongo! Guess again!");
                    break;
                case 29:
                    Console.WriteLine("You guessed 29! Wrongo! Guess again!");
                    break;
                case 7:
                    Console.WriteLine("You guessed 7! Nope. Try again!");
                    break;
                case 12:
                    Console.WriteLine("You guessed 12 and that's right!");
                    break;
                default:
                    Console.WriteLine("You suck at guessing numbers.");
                    break;
                    
            }
            Console.ReadLine();
        }

    }
}
