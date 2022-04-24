using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class step222
{
    static void Main()
    {
        string[] stringArray = { "hi", "hello", "howdy", "hiya", "hey", "what up" };
        int stringArrayLength = stringArray.Length;

        Console.WriteLine("Please select an index of an array of strings to display: ");
        int userStringSelectedIndex = Convert.ToInt32(Console.ReadLine());
        if (userStringSelectedIndex <= 0 || userStringSelectedIndex > (stringArrayLength - 1))
        {
            Console.WriteLine("Please reselect as your choice is beyond the array's length.\n");
            Main();
        }
        else
        {
            string selectedStringIndex = stringArray[userStringSelectedIndex];
            Console.WriteLine("The string represented at index " + userStringSelectedIndex + " is " + selectedStringIndex + ".\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            NumberArray();
        }

        void NumberArray()
        {
            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int numArrayLength = numArray.Length;

            Console.WriteLine("Please select an index of a string of numbers to display: ");
            int userNumSelectedIndex = Convert.ToInt32(Console.ReadLine());
            if (userNumSelectedIndex <= 0 || userNumSelectedIndex > (numArrayLength - 1))
            {
                Console.WriteLine("Please reselect as your choice is beyond the array's length.\n");
                NumberArray();
            }
            else
            {
                int selectedNumIndex = numArray[userNumSelectedIndex];
                Console.WriteLine("The number represented at index " + userNumSelectedIndex + " is " + selectedNumIndex + ".");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                StringList();
            }
        }

        void StringList()
        {
            List<string> stringList = new List<string>();

            stringList.Add("love");
            stringList.Add("compassion");
            stringList.Add("honesty");
            stringList.Add("values");
            stringList.Add("loyalty");
            stringList.Add("cleanliness");

            int countStringList = stringList.Count;

            Console.WriteLine("Please select an index of a list of strings to display: ");
            int userListSelectedIndex = Convert.ToInt32(Console.ReadLine());

            if (userListSelectedIndex <= 0 || userListSelectedIndex > countStringList -1)
            {
                Console.WriteLine("Please reselect as your choice is beyond the list's length.");
                StringList();
            }
            else
            {
                string selectedStringIndex = stringList[userListSelectedIndex];
                Console.WriteLine("The string represented at index " + userListSelectedIndex + " is " + selectedStringIndex + ".\n");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

        }



    }
}

