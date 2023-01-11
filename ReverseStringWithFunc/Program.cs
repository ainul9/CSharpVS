using System;
using System.Globalization;

class reverse1
{
    public static void Main()
    {
        Console.WriteLine("Enter number of element u want to hold in this array: ");
        string s = Console.ReadLine();

        int x = Int32.Parse(s);
        int[] a = new int[x];

        Console.WriteLine("Enter array elements: ");

        for (int i = 0; i<x; i++)
        {
            string s1 = Console.ReadLine();
            a[i] = Int32.Parse(s1);
        }

        Array.Reverse(a);
        Console.WriteLine("Reversed array: ");
        for(int i = 0; i<x; i++)
        {
            Console.WriteLine("Element {0} is {1}", i+1, a[i]);
        }
        Console.Read();
    }
}