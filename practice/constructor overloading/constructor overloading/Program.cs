using System;

class MyClass
{
    private int[] myArray;

    // Default constructor
    public MyClass()
    {
        Console.WriteLine("Default constructor");
    }

    // Overloaded constructor with array parameter
    public MyClass(int[] arr)
    {
        Console.WriteLine("Overloaded constructor with array");
        myArray = arr;
    }

    // Method to display array elements
    public void DisplayArray()
    {
        if (myArray != null)
        {
            Console.Write("Array elements: ");
            foreach (var item in myArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Array is null.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Using default constructor
        MyClass defaultInstance = new MyClass();

        // Using overloaded constructor with array
        int[] myIntArray = { 1, 2, 3, 4, 5 };
        MyClass arrayInstance = new MyClass(myIntArray);

        // Displaying array elements
        arrayInstance.DisplayArray();

        Console.ReadLine();
    }
}
