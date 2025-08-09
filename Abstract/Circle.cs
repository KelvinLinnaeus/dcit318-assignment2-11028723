using System;

public class Circle : Shape
{
  public double Radius { get; }

  public Circle(double radius)
  {
    Radius = radius;
  }

  public override double GetArea()
  {
    return Math.PI * Radius * Radius;
  }
}
