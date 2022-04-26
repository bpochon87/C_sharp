using System;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dividing the two...");
            int quotient = numberOne / numberTwo;
            Console.WriteLine($"{numberOne} divided by {numberTwo} is {quotient}.");
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + "\nPlease enter only a number.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + "\nEnter a number to divide by other than zero.");
        }
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
