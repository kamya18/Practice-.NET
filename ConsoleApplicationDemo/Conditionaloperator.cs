using System;

namespace Conditionaloperator
{
    class Program
    {
        static void Main()
        {
            //odd or even
            // Console.Write("Enter a number: ");
            // int num = int.Parse(Console.ReadLine());

            // string result = (num % 2 == 0 )?"even":"odd";

            // Console.WriteLine($"The number {num} is {result}");

            //max of two nos
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            // Using the conditional operator to find the maximum of two numbers
            int max = (number1 > number2) ? number1 : number2;

            Console.WriteLine($"The maximum number between {number1} and {number2} is: {max}");
        }
    }
}