using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class step222
{
    static void Main()
    {
        // Declaring and initializing array of strings.
        string[] stringArray = { "hi", "hello", "howdy", "hiya", "hey", "what up" };

        // Assigning array length to variable.
        int stringArrayLength = stringArray.Length;

        // Getting user input for selection of an element in the array.
        Console.WriteLine("Please select an index of an array of strings to display: ");

        // Converting while assigning user input to integer.
        int userStringSelectedIndex = Convert.ToInt32(Console.ReadLine());

        // This if else loop will confirm that user input is not out of range of our array length. If it is, the program restarts.
        if (userStringSelectedIndex <= 0 || userStringSelectedIndex > (stringArrayLength - 1))
        {
            Console.WriteLine("Please reselect as your choice is beyond the array's length.\n");
            Main();
        }
        else
        {
            // Inserting user input into our array and finding desired index. Setting desired index to variable.
            string selectedStringIndex = stringArray[userStringSelectedIndex];
            Console.WriteLine("The string represented at index " + userStringSelectedIndex + " is " + selectedStringIndex + ".\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            // Calling our next function to continue program.
            NumberArray();
        }

        void NumberArray()
        {
            // Declaring and initializing array of integers.
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Assigning array length to variable.
            int numArrayLength = numArray.Length;

            // Getting user input for selection of an element in the array.
            Console.WriteLine("Please select an index of a string of numbers to display: ");

            // Converting while assigning user input to integer.
            int userNumSelectedIndex = Convert.ToInt32(Console.ReadLine());

            // This if else loop will confirm that user input is not out of range of our array length. If it is, the function calls itself to restart.
            if (userNumSelectedIndex <= 0 || userNumSelectedIndex > (numArrayLength - 1))
            {
                Console.WriteLine("Please reselect as your choice is beyond the array's length.\n");
                NumberArray();
            }
            else
            {
                // Inserting user input into our array and finding desired index. Setting desired index to variable.
                int selectedNumIndex = numArray[userNumSelectedIndex];
                Console.WriteLine("The number represented at index " + userNumSelectedIndex + " is " + selectedNumIndex + ".");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

                // Calling our next function to continue program.
                StringList();
            }
        }

        void StringList()
        {
            // Declaring and initializing list.
            List<string> stringList = new List<string>();

            // Populating list with strings.
            stringList.Add("love");
            stringList.Add("compassion");
            stringList.Add("honesty");
            stringList.Add("values");
            stringList.Add("loyalty");
            stringList.Add("cleanliness");

            // Assigning list length to variable by counting all list elements.
            int countStringList = stringList.Count;

            // Getting user input for selection of an element in the list.
            Console.WriteLine("Please select an index of a list of strings to display: ");
            int userListSelectedIndex = Convert.ToInt32(Console.ReadLine());

            // This if else loop will confirm that user input is not out of range of our list length. If it is, the function calls itself to restart.
            if (userListSelectedIndex <= 0 || userListSelectedIndex > countStringList -1)
            {
                Console.WriteLine("Please reselect as your choice is beyond the list's length.");
                StringList();
            }
            else
            {
                // Inserting user input into our list and finding desired index. Setting desired index to variable.
                string selectedStringIndex = stringList[userListSelectedIndex];
                Console.WriteLine("The string represented at index " + userListSelectedIndex + " is " + selectedStringIndex + ".\n");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

        }



    }
}

