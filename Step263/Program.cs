using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Populated list of numbers.
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("Hello. Please enter a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // 'For' loop that'll divide our list items by the user input.
            for (int i = 0; i < numbers.Count; i++)
            {
                int quotient = numbers[i] / userNumber;
                Console.WriteLine($"{numbers[i]} divided by {userNumber} is {quotient}.");
            }

        // Catching user input of a string.
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + "\nText input is invalid. Please enter a number.");
        }

        // Catching user input of a zero.
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + "\nEnter a number other than zero to divide by.");
        }

        // Catching all other exceptions.
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

    }
}
