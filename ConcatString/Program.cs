using System;

    class Program
    {
        static void Main()
    {
        string s1 = "What is";
        string s2 = " your problem?";
        string s3 = string.Concat(s1, s2);
        Console.WriteLine(s3);
        Console.ReadLine();
    }
    }
