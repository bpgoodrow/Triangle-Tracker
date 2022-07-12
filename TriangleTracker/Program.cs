using System;
using TriangleTracker.Models;

namespace UserInterface
{
  public class Program
  {
    public static void Main()
    {
      

      Console.WriteLine("Enter Triangle Side 1");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Triangle Side 2");
      int num2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter Triangle Side 3");
      int num3 = int.Parse(Console.ReadLine());
      
      TriangleLogic notATriangle = new TriangleLogic(num1, num2, num3);
      TriangleLogic equilateral = new TriangleLogic(num1, num2, num3);
      TriangleLogic isoceles = new TriangleLogic(num1, num2, num3);
      TriangleLogic scalene = new TriangleLogic(num1, num2, num3);
      IsTriangle(num1, num2, num3);
    }
  }
}