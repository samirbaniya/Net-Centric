using System;

public class GenericClass<T>
{
    public T Generic;

    public GenericClass(T a)
    {
        Generic = a;
    }
}

class Program
{
    static void Main()
    {
        // Example with int
        GenericClass<int> intobj = new GenericClass<int>(42);
        Console.WriteLine($"Value: {intobj.Generic}");

        // Example with string
        GenericClass<string> stringobj = new GenericClass<string>("Hello, generics!");
        Console.WriteLine($"Value: {stringobj.Generic}");

        Console.ReadLine();
    }
}
