namespace TriangleTracker.Models
{
  public class TriangleLogic
  {
    public bool IsTriangle(int num1, int num2, int num3)
    {
      if ((num1 + num2 <= num3 || num1 + num3 <= num2 || num2 + num3 <= num1) || (num1 + num2 >= num3 || num1 + num3 >= num2 || num2 + num3 >= num1))
      {
        return true;
      }
      // check if all sides are equal
      else if (num1 == num2 && num1 == num3 && num2 == num3)
      {
        return true;
      }
      // check if isoceles
      else if (num1 == num2 || num1 == num3 || num2 == num3)
      {
        return true;
      }
      // check if no sides are equal 
      else if (num1 != num2 && num1 != num3 && num2 != num3)
      {
        return true;
      }
      // check if not a triangle
      else
      {
        return false;
      }
    }
  }
}