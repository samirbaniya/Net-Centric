using System;

public class GenericExample
{
    // Generic function
    public static void DisplayValue<T>(T a)
    {
        Console.WriteLine($"The value is: {a}");
    }

    static void Main()
    {
        // Explicitly specifying type <int>
        DisplayValue<int>(42);

        // Explicitly specifying type <string>
        DisplayValue<string>("Hello, generics!");

        // Explicitly specifying type <double>
        DisplayValue<double>(3.14);

        Console.ReadLine();
    }
}
