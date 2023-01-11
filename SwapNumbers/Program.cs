using System;

namespace Swap
{
    class Swap
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("\nFirst number: " + num1);
            Console.WriteLine("\nSecond number: " + num2);
            Console.Read(); //same as Console.ReadLine();
           

        }
    }
}