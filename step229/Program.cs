using System;

namespace step229
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number under 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number <= 0 || number > 10)
            {
                Console.WriteLine(number + " is not a valid number for this game!\n");
                Main();
                break;
            }
            bool isGuessed = false;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("1 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("2 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("3 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("4 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("5 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine("6 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 8:
                        Console.WriteLine("8 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 9:
                        Console.WriteLine("9 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("10 is incorrect.");
                        Console.WriteLine("Please guess again:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                        Console.WriteLine("7 is correct!");
                        isGuessed = true;
                        break;
                }
            }
            while (isGuessed == false);
            Console.Read();
        }
            
    }
}
