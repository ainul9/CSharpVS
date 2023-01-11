using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
           string yesOrNo;
            do
            {

                int result;
                Console.WriteLine("Choose your operation ( +, -, *, /): ");
                string operation = Console.ReadLine();
                Console.WriteLine("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("The result of the addition is: " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("The result of substraction is: " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("The result of multiplication is: " + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("The result of division is: " + result);
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.Read();
                Console.WriteLine("Type Y if want to continue: ");
                yesOrNo = Console.ReadLine();
            } while (yesOrNo == "Y");
        }
    }
}