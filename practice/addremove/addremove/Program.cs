using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a dictionary
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        // Adding elements to the dictionary
        myDictionary["One"] = 1;
        myDictionary["Two"] = 2;
        myDictionary["Three"] = 3;

        // Displaying the dictionary before removal
        Console.WriteLine("Dictionary before removal:");
        foreach (var pair in myDictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        // Removing an element based on key
        string keyToRemove = "Two";
        myDictionary.Remove(keyToRemove);
        Console.WriteLine($"\nElement with key '{keyToRemove}' removed successfully.");

        // Displaying the dictionary after removal
        Console.WriteLine("\nDictionary after removal:");
        foreach (var pair in myDictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        Console.ReadLine();
    }
}
