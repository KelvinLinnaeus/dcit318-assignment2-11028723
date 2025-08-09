using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("=== Abstract Classes & Methods Demo ===\n");

    Circle c = new Circle(3.5); // example radius
    Rectangle r = new Rectangle(4.0, 5.5); // example width and height

    Console.WriteLine($"Circle (radius = {c.Radius}) area: {c.GetArea():F4}");
    Console.WriteLine($"Rectangle (w = {r.Width}, h = {r.Height}) area: {r.GetArea():F4}");

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
  }
}
