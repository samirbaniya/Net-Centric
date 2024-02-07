using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Interface for flying behavior
interface IFlyable
{
    void Fly();
}

// Interface for swimming behavior
interface ISwimmable
{
    void Swim();
}

// Derived class implementing IFlyable and inheriting from Animal
class Bird : Animal, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }
}

// Derived class implementing ISwimmable and inheriting from Animal
class Fish : Animal, ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Fish is swimming.");
    }
}

// Hybrid class implementing both IFlyable and ISwimmable
class HybridAnimal : Animal, IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("HybridAnimal is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("HybridAnimal is swimming.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of the derived classes
        Bird myBird = new Bird();
        Fish myFish = new Fish();
        HybridAnimal myHybridAnimal = new HybridAnimal();

        // Accessing methods from the base class and interfaces
        myBird.Eat();       // Method from Animal (base class)
        myBird.Fly();       // Method from IFlyable

        myFish.Eat();       // Method from Animal (base class)
        myFish.Swim();      // Method from ISwimmable

        myHybridAnimal.Eat();  // Method from Animal (base class)
        myHybridAnimal.Fly();  // Method from IFlyable
        myHybridAnimal.Swim(); // Method from ISwimmable

        Console.ReadLine();
    }
}
