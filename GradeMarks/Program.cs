using System;

class Program
{
    static void Main(string[] args)
    {
        double id, malay, eng, art, total;
        double avg;
        string name, grade;

        Console.WriteLine("Calculate the total marks, average and students grade.\n");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("\n\n");

        Console.WriteLine("Enter student id: ");
        id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student name: ");
        name = Console.ReadLine();

        Console.WriteLine("Enter mark for Malay subject: ");
        malay = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter mark for English subject: ");
        eng = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter mark for Art subject: ");
        art = Convert.ToDouble(Console.ReadLine());

        total = malay + eng + art;
        avg = total / 3.0;
        if (avg >= 80)
        {
            grade = "A";
        }
        else if (avg < 80 && avg >= 60)
        {
            grade = "B";
        }
        else if (avg < 60 && avg <= 50)
        {
            grade = "C";
        }
        else
        {
            grade = "failed";
        }

        Console.WriteLine("Id Number: {0}\nStudent Name: {1}\n", id, name);
        Console.WriteLine("Marks in Malay: {0}\nMarks in English: {1}\nMarks in Art: {2}\n", malay, eng, art);
        Console.WriteLine("Total Marks = {0}\nAverage = {1}\nGrade = {2}\n", total, avg, grade);

        Console.Read();
    }
}