using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Intermediate class derived from Animal
class Mammal : Animal
{
    public void GiveBirth()
    {
        Console.WriteLine("Mammal is giving birth.");
    }
}

// Derived class derived from Mammal
class Dog : Mammal
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

        // Accessing methods from different levels of inheritance
        myDog.Eat();        // Method from Animal (base class)
        myDog.GiveBirth();  // Method from Mammal (intermediate class)
        myDog.Bark();       // Method from Dog (derived class)

        Console.ReadLine();
    }
}
