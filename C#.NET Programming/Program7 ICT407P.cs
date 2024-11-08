using System;

public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y);

    public override string ToString() => $"({X}, {Y})";
}

public enum grade: byte
{
    O =  10,
    A = 8,
    B = 6,
    C = 5
}

// demonstrating inheritance and concept of constructors
class Animal
{
    public Animal(string name)
    {
        Console.WriteLine($"Name of Animal has been set as {name}.");
    }
    
    public virtual void sound()
    {
        Console.WriteLine("Animal makes some sound.");
    }
}

class Dog: Animal
{
    public Dog(string name): base(name)
    {
        Console.WriteLine($"Your dog {name} is very cute!");
    }
    
    public override void sound()
    {
        Console.WriteLine("Dog barks.");
    }
}

class ICT407PAssignment7
{
  public static void Main()
  {     
    // demonstrating structures in C#
    var p1 = new MutablePoint(1, 2);
    var p2 = p1;
    p2.Y = 200;
    Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
    Console.WriteLine($"{nameof(p2)}: {p2}");
    
    // demonstrating enumerations in C#
    Console.WriteLine($"Corresponding score for A grade is {(int)grade.A}");
    
    // demonstrating concept of polymorphism
    Animal a = new Animal("Pony");
    Dog d = new Dog("Casper");
    
    a.sound();
    a = d;
    a.sound();
  }
}