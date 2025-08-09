using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("=== Interfaces Demo ===\n");

    IMovable car = new Car();
    IMovable bicycle = new Bicycle();

    Console.Write("Car: ");
    car.Move();

    Console.Write("Bicycle: ");
    bicycle.Move();

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
  }
}
