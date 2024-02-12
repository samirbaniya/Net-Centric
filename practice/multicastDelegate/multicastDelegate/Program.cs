using System;

class Program
{
    public delegate void MathOperation(int a, int b);
    static void Main()
    {
        // Create an instance of the delegate
        MathOperation mathDelegate = Sum;

        // Add another method (Multiply) to the delegate using the '+' operator
        mathDelegate += Multiply;

        // Invoke the delegate
        mathDelegate(3, 5);

        Console.ReadLine();
    }

    static void Sum(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    static void Multiply(int a, int b)
    {
        Console.WriteLine("Multiply: " + (a * b));
    }
}
