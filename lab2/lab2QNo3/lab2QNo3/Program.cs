using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2QNo3
{
    internal class Program
    {

        class FunctionOverloadingExample
        {
            // FunctionOverloading with different types of parameters
            public static void DisplayInfo(int a)
            {
                Console.WriteLine($"Integer value: {a}");
            }

            public static void DisplayInfo(double a)
            {
                Console.WriteLine($"Double value: {a}\n");
            }

            // FunctionOverloading with different number of parameters
            public static int AddNumbers(int a, int b)
            {
                return a + b;
            }

            public static int AddNumbers(int a, int b, int c)
            {
                return a + b + c;
            }

            // FunctionOverloading with the order of arguments
            public static void DisplayOrder(string name, int rollNo)
            {
                Console.WriteLine($"\nName: {name} Roll No.: {rollNo}");
            }

            public static void DisplayOrder(int rollNo, string name)
            {
                Console.WriteLine($"Name: {name} Roll No.: {rollNo}");
            }

            static void Main()
            {
                // Example of different types of parameters
                DisplayInfo(42);
                DisplayInfo(3.14);

                // Example of different number of parameters
                Console.WriteLine("Sum of two numbers: " + AddNumbers(5, 10));
                Console.WriteLine("Sum of three numbers: " + AddNumbers(5, 10, 15));

                // Example of the order of arguments
                DisplayOrder("John", 12);
                DisplayOrder(12, "John");

                Console.ReadLine();
            }
        }

    }
}
