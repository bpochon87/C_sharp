using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userNumber = Console.ReadLine();

            // This 'WriteAllText' method only accepts strings.
            File.WriteAllText(@"D:\Users\bpoch\Desktop\log.txt", (string)userNumber);

            string printUserNumber = File.ReadAllText(@"D:\Users\bpoch\Desktop\log.txt");

            Console.WriteLine(printUserNumber);
            Console.ReadLine();

        }
    }
}
