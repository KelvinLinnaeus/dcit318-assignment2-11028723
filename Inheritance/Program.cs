using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("=== Inheritance & Method Overriding Demo ===\n");

    Animal generic = new Animal();
    Animal dog = new Dog();
    Animal cat = new Cat();

    Console.Write("Animal: ");
    generic.MakeSound();

    Console.Write("Dog: ");
    dog.MakeSound();

    Console.Write("Cat: ");
    cat.MakeSound();

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
  }
}
