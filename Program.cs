using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Declaring and initialing an array of strings.
        string[] nameArray = { "Brady", "Sara", "Suerte", "Ron", "Dale Dee", "Terry", "John" };

        // Getting user input and assigning it to a variable.
        Console.WriteLine("Please enter some text: ");
        string userInput = Console.ReadLine();

        // For loop iterating through each array index and appending userInput to it.
        // Loop runs through the first three indices - 0, 1, 2.
        for (int i = 0; i <= 2; i++)
        {
            string fullText = nameArray[i] + " " + userInput;
            Console.WriteLine(fullText);
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        FindIndex();

        void FindIndex()
        {
            // Declaring and instatiating a list of strings.
            List<string> firstNames = new List<string>() { "Jeremy", "Kelli", "Sawyer", "Ryder", "Harper", "Dre", "Lucy", "Timon" };

            // Getting user input and assigning it to a variable.
            Console.WriteLine("Please enter a capitalized first name from the Smith family: ");
            string userInputName = Console.ReadLine();

            // User input being assigned to integer that will search for matches and return index.
            int indexOfUserFirstName = firstNames.IndexOf(userInputName);
            if (indexOfUserFirstName >= 0)
            {
                Console.WriteLine($"That name has been found at index {indexOfUserFirstName}.");
            }
            else
            {
                Console.WriteLine("That name was not found.");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Identical();
        }

        void Identical()
        {
            // Declare and instantiate list.
            List<string> greetings = new List<string>() { "Hello", "Hi", "Hey", "Howdy", "Good day", "Hello", "Hiya" };

            // Getting user input and assigning it to a variable.
            Console.WriteLine("Please enter a capitalized greeting (e.g. Hiya) to search for: ");
            string userGreetingInput = Console.ReadLine();

            // This will be changed to true if user input matches a string in the list.
            bool checker = false;

            // For loop checking for correct condition to be met.
            for (int i = 0; i < greetings.Count; i++)
            {
                if (greetings[i] == userGreetingInput)
                {
                    Console.WriteLine(userGreetingInput + ": " + i);
                    checker = true;
                }

            }
            if (checker == false)
            {
                Console.WriteLine("This item doesn't appear on list.");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            NewList();
        }

        void NewList()
        {
            List<string> salutations = new List<string>() { "Hello", "Hi", "Hey", "Howdy", "Good day", "Hello", "Hiya" };

            // Empty list to store single copy of each list item from salutations list.
            List<string> duplicates = new List<string>();

            // Iterating through populated list.
            foreach (string salute in salutations)
            {
                // Assigning boolean to check for correct condition in foreach loop.
                bool checker = false;
                foreach (string duplicate in duplicates)
                {
                    if (duplicate == salute)
                    {
                        checker = true;
                    }
                }
                if (checker == true)
                {
                    Console.WriteLine(salute + " has already appeared on the list.");
                }
                else
                {
                    duplicates.Add(salute);
                    Console.WriteLine(salute);
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
