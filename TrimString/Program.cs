using System;
namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "     Love your Life    ";
            Console.WriteLine("The string before trimming: " + str1);
            Console.WriteLine("The string after trimming: " + str1.Trim()); //trim function is to remove spaces in string
            Console.Read();
        }
    }
}