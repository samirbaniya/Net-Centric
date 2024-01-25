using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, %, /):");
            char op = char.Parse(Console.ReadLine());

            int result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    if (num1 < num2)
                    {
                        int temp = num1;
                        num1 = num2;
                        num2 = temp;
                    }
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '%':
                    result = num1 % num2;
                    break;

                case '/':
                    if (num2 != 0) // Ensure no division by zero
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return; // Exit the program
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    Console.ReadLine();

                    return; // Exit the program
            }


            Console.WriteLine($"Result: {result} ");
            Console.ReadLine();
        }
    }
}
