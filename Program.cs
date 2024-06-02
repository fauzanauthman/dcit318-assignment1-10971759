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
        // Add more options here if desired
        Console.WriteLine("This option is not yet implemented.");
      }
      else
      {
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
      }
    }
  }

  public static int GetMenuChoice()
  {
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Triangle Type Identifier");
    Console.WriteLine("2. Grade Calculator");
    Console.WriteLine("3. (Optional) Add more options here");
    Console.Write("Enter your choice: ");
    return int.Parse(Console.ReadLine());
  }

  public static void IdentifyTriangleType()
  {
    // ... (existing code for identifying triangle type)
  }

  public static void CalculateGrade()
  {
    // ... (existing code for calculating grade)
  }
}
