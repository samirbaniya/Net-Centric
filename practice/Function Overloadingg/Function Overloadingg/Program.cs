using System;

class ArrayOverloadingExample
{
    // Method with int array parameter
    public static void ProcessArray(int[] arr)
    {
        Console.WriteLine("Processing int array");
        foreach (int item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    // Method with double array parameter
    public static void ProcessArray(double[] arr)
    {
        Console.WriteLine("Processing double array");
        foreach (double item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] intArray = { 1, 2, 3 };
        double[] doubleArray = { 1.1, 2.2, 3.3 };

        // Call methods based on array types
        ProcessArray(intArray);
        ProcessArray(doubleArray);

        Console.ReadLine();
    }
}
