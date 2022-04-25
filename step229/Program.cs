using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 99, 98, 54, 88, 66, 72, 100, 33, 88, 77, 68 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>();

        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(87);
        //testScores.Add(56);
        //testScores.Add(77);
        //testScores.Add(94);
        //testScores.Add(86);

        //foreach (int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score." + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Brady", "Sara", "Suerte", "Ron", "Dale", "Terry", "John" };

        //foreach (string name in names)
        //{
        //    if (name == "Brady")
        //    {
        //        Console.WriteLine(name + " is a cool name.");
        //    }
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 86, 87, 73, 73, 68, 36 };
        List<int> passingScores = new List<int>();


        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        



    }            
}

