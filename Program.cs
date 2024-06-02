using System;

public class TriangleTypeIdentifier
{
  public static void Main(string[] args)
  {
    float side1, side2, side3;

    while (true)
    {
      try
      {
        Console.Write("Enter the length of side 1: ");
        side1 = float.Parse(Console.ReadLine());
        Console.Write("Enter the length of side 2: ");
        side2 = float.Parse(Console.ReadLine());
        Console.Write("Enter the length of side 3: ");
        side3 = float.Parse(Console.ReadLine());
        if (side1 > 0 && side2 > 0 && side3 > 0)
        {
          break;
        }
        else
        {
          Console.WriteLine("Invalid side length. Please enter positive numbers.");
        }
      }
      catch (FormatException)
      {
        Console.WriteLine("Invalid input. Please enter numbers for side lengths.");
      }
    }

    string triangleType;
    if (side1 == side2 && side1 == side3)
    {
      triangleType = "Equilateral";
    }
    else if (side1 == side2 || side1 == side3 || side2 == side3)
    {
      triangleType = "Isosceles";
    }
    else
    {
      triangleType = "Scalene";
    }

    Console.WriteLine($"The triangle is: {triangleType}");
  }
}
