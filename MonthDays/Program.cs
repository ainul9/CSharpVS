using System;

class Program
{
    static void Main(string[] args)
    {
        int month;

        Console.WriteLine("Enter number of month (1-12): ");
        month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1:
                Console.WriteLine("Month : January\nNumber of days:31\n");
                break;
            case 2:
                Console.WriteLine("Month : February\nNumber of days:28\n");
                break;
            case 3:
                Console.WriteLine("Month : March\nNumber of days:31\n");
                break;
            case 4:
                Console.WriteLine("Month : April\nNumber of days:30\n");
                break;
            case 5:
                Console.WriteLine("Month : May\nNumber of days:31\n");
                break;
            case 6:
                Console.WriteLine("Month : June\nNumber of days:30\n");
                break;
            case 7:
                Console.WriteLine("Month : July\nNumber of days:31\n");
                break;
            case 8:
                Console.WriteLine("Month : August\nNumber of days:31\n");
                break;
            case 9:
                Console.WriteLine("Month : September\nNumber of days:30\n");
                break;
            case 10:
                Console.WriteLine("Month : October\nNumber of days:31\n");
                break;
            case 11:
                Console.WriteLine("Month : November\nNumber of days:30\n");
                break;
            case 12:
                Console.WriteLine("Month : December\nNumber of days:31\n");
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        } Console.Read();
    }
}