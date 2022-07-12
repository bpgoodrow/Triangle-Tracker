using System;

namespace TriangleTracker
{
  public class TriangleLogic
  {
    public static void Main()
    {
      

      Console.WriteLine("Enter Triangle Side 1");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Triangle Side 2");
      int num2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Triangle Side 3");
      int num3 = int.Parse(Console.ReadLine());
    }
      public static void isTriangle(int num1, int num2, int num3)
      {
        if (num1 + num2 <= num3 || num1 + num3 <= num2 || num2 + num3 <= num1)
        {
          Console.WriteLine("This is not a triangle");
        }
        // check if all sides are equal
        else if (num1 == num2 && num1 == num3 && num2 == num3)
        {
          Console.WriteLine("Equilateral");
        }
        // check if isoceles
        else if (num1 == num2 || num1 == num3 || num2 == num3)
        {
          Console.WriteLine("Isosceles");
        }
        // check if no sides are equal 
        else if (num1 != num2 && num1 != num3 && num2 != num3)
        {
          Console.WriteLine("Scalene");
        }
        // check if not a triangle
        else
        {
          Console.WriteLine("Impossible");
        }
      }
    }
  }
