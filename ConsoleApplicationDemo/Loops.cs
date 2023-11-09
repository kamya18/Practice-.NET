using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //swap of first and last digits
            // int num, last, first, temp, count = 0;
            // double swap;
            // Console.WriteLine("Enter number: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // temp = num;
            // last = temp % 10;
            // count = (int)Math.Log10(temp);
            // while (temp >= 10)
            // {
            //     temp /= 10;
            // }
            // first = temp;
            // swap = (last * Math.Pow(10, count) + first) + (num - (first * Math.Pow(10, count) + last));
            // Console.WriteLine("Last Digit:" + last);
            // Console.WriteLine("First Digit:" + first);
            // Console.WriteLine(num + " is swapped to " + swap);
            // Console.ReadLine();

            //sum of first and last digit
            // int num, sum = 0, firstDigit, lastDigit;
            // Console.Write("Enter any number: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // lastDigit = num % 10;
            // firstDigit = num;
            // while (num >= 10)
            // {
            //     num = num / 10;
            // }
            // firstDigit = num;
            // sum = firstDigit + lastDigit;
            // Console.WriteLine("Sum of first and last digit: " + sum);
            // Console.ReadLine();

            //product of digits
            // int num, product = 1;
            // Console.Write("Enter any number: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // while (num != 0)
            // {
            //     product = product * (num % 10);
            //     num = num / 10;
            // }
            // Console.WriteLine("Product of digits = " + product);
            // Console.ReadLine();

            //reverse number
            // int num, rev = 0;
            // Console.Write("Enter any number: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // while (num > 0)
            // {
            //     rev = rev * 10;
            //     rev = rev + num % 10;
            //     num = num / 10;
            // }
            // Console.Write("Reversed number is = " + rev);
            // Console.ReadLine();

            //calculate power using while and for loop
            //while loop
            // int basenumber, exponent, power, i;
            // Console.Write("Enter any number: ");
            // basenumber = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter any number: ");
            // exponent = Convert.ToInt32(Console.ReadLine());
            // power = 1;
            // i = 1;
            // while (i <= exponent)
            // {
            //     power = power * basenumber;
            //     i++;
            // }
            // Console.Write("Power : " + power);
            // Console.ReadLine();

            //for loop
            // int basenumber, exponent, i, power;
            // Console.Write("Enter any number: ");
            // basenumber = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter any number: ");
            // exponent = Convert.ToInt32(Console.ReadLine());
            // power = 1;
            // for (i = 1; i <= exponent; i++)
            //     power = power * basenumber;
            // Console.Write("Power : " + power);
            // Console.ReadLine();

            //find factorial
            // int num, i;
            // long fact = 1;
            // Console.Write("Enter any number to calculate factorial:  ");
            // num = Convert.ToInt32(Console.ReadLine());
            // fact = 1;
            // i = 1;
            // while (i <= num)
            // {
            //     fact = fact * i;
            //     i++;
            // }
            // Console.Write("Factorial of : " + num + " is " + fact);
            // Console.ReadLine();

            //Armstrong number
            // int num, sum = 0, i, r;
            // Console.Write("Please enter a number: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // for (i = num; i > 0; i = i / 10)
            // {
            //     r = i % 10;
            //     sum = sum + r * r * r;
            // }
            // if (num == sum)
            // {
            //     Console.WriteLine(num + " is an armstrong number.");
            // }
            // else
            // {
            //     Console.WriteLine(num + " is not an armstrong number.");
            // }
            // Console.ReadLine();

            //calculate compound interest
            // float amount, rate, intrest, time, ci, a;
            // Console.Write("Type the amount : ");
            // amount = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Type the interest rate : ");
            // rate = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Type the period in years: ");
            // time = Convert.ToInt32(Console.ReadLine());
            // intrest = 1 + (rate / 100);
            // ci = 1;
            // for (a = 1; a <= time; a++)
            //     ci = ci * intrest;
            // ci = amount * ci - amount;
            // Console.WriteLine("Your compound interest is : " + ci);
            // Console.ReadLine();

            //prime number
            // int num, i, f;
            // Console.Write("Enter any number: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // f = 0;
            // i = 2;
            // while (i <= num / 2)
            // {
            //     if (num % i == 0)
            //     {
            //         f = 1;
            //         break;
            //     }
            //     i++;
            // }
            // if (f == 0)
            //     Console.WriteLine(num + " is a Prime Number");
            // else
            //     Console.WriteLine(num + " is not a Prime Number");
            // Console.ReadLine();

            //palindrome
            // int num, i, rev;
            // Console.Write("Enter any number: ");
            // num = Convert.ToInt32(Console.ReadLine());
            // rev = num;
            // for (i = 0; num > 0; num = num / 10)
            // {
            //     i = i * 10;
            //     i = i + (num % 10);
            // }
            // if (rev == i)
            //     Console.WriteLine(rev + " is a Palindrome Number.");
            // else
            //     Console.WriteLine(rev + " is not a Palindrome Number.");
            // Console.ReadLine();

            //print number in words
            // int n, num = 0;
            // Console.WriteLine("Enter any number to print in words: ");
            // n = Convert.ToInt32(Console.ReadLine());
            // while (n != 0)
            // {
            //     num = (num * 10) + (n % 10);
            //     n /= 10;
            // }
            // while (num != 0)
            // {
            //     switch (num % 10)
            //     {
            //         case 0:
            //             Console.Write("zero ");
            //             break;
            //         case 1:
            //             Console.Write("one ");
            //             break;
            //         case 2:
            //             Console.Write("two ");
            //             break;
            //         case 3:
            //             Console.Write("three ");
            //             break;
            //         case 4:
            //             Console.Write("four ");
            //             break;
            //         case 5:
            //             Console.Write("five ");
            //             break;
            //         case 6:
            //             Console.Write("six ");
            //             break;
            //         case 7:
            //             Console.Write("seven ");
            //             break;
            //         case 8:
            //             Console.Write("eight ");
            //             break;
            //         case 9:
            //             Console.Write("nine ");
            //             break;
            //     }
            //     num = num / 10;
            // }
            // Console.ReadLine();

            //HCF
            // int i, num1, num2, min, HCF = 1;
            // Console.WriteLine("Enter any number to print in words: ");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // num2 = Convert.ToInt32(Console.ReadLine());
            // min = (num1 < num2) ? num1 : num2;
            // for (i = 1; i <= min; i++)
            // {
            //     if (num1 % i == 0 && num2 % i == 0)
            //     {
            //         HCF = i;
            //     }
            // }
            // Console.WriteLine("HCF of " + num1 + " and " + num2 + " is: " + HCF);
            // Console.ReadLine();

            //LCM
            int num1, num2, x, y, lcm = 0;
            Console.Write("Enter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            x = num1;
            y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            lcm = (x * y) / num1;
            Console.Write("Least Common Multiple is : " + lcm);
            Console.ReadLine();
        }
    }
}