using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class inheriting from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the derived class
        Dog myDog = new Dog();

        // Accessing the method from the base class
        myDog.Eat();

        // Accessing the method from the derived class
        myDog.Bark();
        Console.ReadLine();
    }
}
