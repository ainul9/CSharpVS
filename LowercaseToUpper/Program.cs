using System;

namespace changeCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int i;

            while (true)
            {
                Console.WriteLine("Enter the character: ");
                a = Convert.ToChar(Console.ReadLine());
                i = (int)a;
                if (a >= 65 && a <= 90)
                {
                    Console.WriteLine("The character is: {0}", char.ToLower(a));

                }
                else if (a >= 97 && a <= 122)
                {
                    Console.WriteLine("The character is: {0}", char.ToUpper(a));
                }
                else
                {
                    Console.WriteLine("Something wrong");
                }
                
            } Console.Read();
        }
    }
}