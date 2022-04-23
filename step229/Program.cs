using System;

namespace step229
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 7;

            do
            {
                switch (number)
                {
                    case 5:
                        Console.WriteLine("5 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("10 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 15:
                        Console.WriteLine("15 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("8 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("7 is correct!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Keep trying.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (isGuessed);
            Console.Read();
        }
            
    }
}
