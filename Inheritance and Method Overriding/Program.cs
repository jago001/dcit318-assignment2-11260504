using System;

// Base class Animal
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each class
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call MakeSound() on each instance
        Console.WriteLine("Animal sound:");
        animal.MakeSound();

        Console.WriteLine("\nDog sound:");
        dog.MakeSound();

        Console.WriteLine("\nCat sound:");
        cat.MakeSound();
    }
}
