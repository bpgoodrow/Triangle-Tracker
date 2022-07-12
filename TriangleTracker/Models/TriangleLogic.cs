using System;

namespace TriangleTracker.Models {
  
  public class TriangleLogic
  {

    public int Num1 { get; set; }
    public int Num2 { get; set; }
    public int Num3 { get; set; }

    public TriangleLogic(int num1, int num2, int num3)
    {
      Num1 = num1;
      Num2 = num2;
      Num3 = num3;
    }

    public static void IsTriangle(int num1, int num2, int num3)
    {
      if ((num1 + num2 <= num3 || num1 + num3 <= num2 || num2 + num3 <= num1) || (num1 + num2 >= num3 || num1 + num3 >= num2 || num2 + num3 >= num1))
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