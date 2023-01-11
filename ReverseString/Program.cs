using System;

class Program
{
    static void Main(string[] args)
    {
        string Str, reversestring = "";
        int Length;

        Console.WriteLine("Enter a string: ");
        Str = Console.ReadLine();

        Length = Str.Length - 1; //in order to get length = index of the last letter in the string. 

        while(Length >= 0) //keep on performing this while Length > = 0
        {
            reversestring = reversestring + Str[Length];
            Length--; //if Length = -1, then this operation stops and directly jump out of the loop.
        }

        Console.WriteLine("Reverse string is {0}", reversestring); // to print to the string start from the current first index after loop, which the letter is already reversed.
        Console.ReadLine();
    }
}