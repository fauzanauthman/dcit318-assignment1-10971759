using System;

public class MultipurposeCalculator
{
  public static void Main(string[] args)
  {
    while (true)
    {
      int choice = GetMenuChoice();

      if (choice == 1)
      {
        IdentifyTriangleType();
      }
      else if (choice == 2)
      {
        CalculateGrade();
      }
      else if (choice == 3)
      {
        CalculateTicketPrice();
      }
      else if (choice == 4)
      {
        Console.WriteLine("Exiting...");
        break;
      }
      else
      {
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
      }
    }
  }

  public static int GetMenuChoice()
  {
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Triangle Type Identifier");
    Console.WriteLine("2. Grade Calculator");
    Console.WriteLine("3. Ticket Price Calculator");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your choice: ");
    return int.Parse(Console.ReadLine());
  }

    public static void IdentifyTriangleType()
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

   public static void CalculateGrade()
  {
    float score;

    while (true)
    {
      try
      {
        Console.Write("Enter your numerical grade (0-100): ");
        score = float.Parse(Console.ReadLine());
        if (score >= 0 && score <= 100)
        {
          break;
        }
        else
        {
          Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
        }
      }
      catch (FormatException)
      {
        Console.WriteLine("Invalid input. Please enter a number.");
      }
    }

    string letterGrade = "F";
    if (score >= 90)
    {
      letterGrade = "A";
    }
    else if (score >= 80)
    {
      letterGrade = "B";
    }
    else if (score >= 70)
    {
      letterGrade = "C";
    }
    else if (score >= 60)
    {
      letterGrade = "D";
    }

    Console.WriteLine($"Your letter grade is: {letterGrade}");
  }
  
  public static void CalculateTicketPrice()
  {
    int age;

    while (true)
    {
      try
      {
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());
        if (age >= 0)
        {
          break;
        }
        else
        {
          Console.WriteLine("Invalid age. Please enter a non-negative number.");
        }
      }
      catch (FormatException)
      {
        Console.WriteLine("Invalid input. Please enter a number.");
      }
    }

    const decimal basePrice = 10m; // Use decimal for currency
    decimal ticketPrice = basePrice;

    if (age <= 12 || age >= 65)
    {
      ticketPrice = 7m; // Discounted price
    }

    Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
  }
}

