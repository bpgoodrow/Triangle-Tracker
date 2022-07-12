using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void CheckEquilateral_IfAllSidesAreEqual_True()
    {
      TriangleLogic testTriangleLogic = new TriangleLogic();
      Assert.AreEqual(true, testTriangleLogic.IsTriangle(3, 3 ,3));
    }

    [TestMethod]
    public void CheckIsosceles_IfTwoSidesEqual_True()
    {
      TriangleLogic testTriangleLogic = new TriangleLogic();
      Assert.AreEqual(true, testTriangleLogic.IsTriangle(1, 3 ,3));
    }

    [TestMethod]
    public void CheckScalene_IfNoSidesEqual_True()
    {
      TriangleLogic testTriangleLogic = new TriangleLogic();
      Assert.AreEqual(true, testTriangleLogic.IsTriangle(2, 4 ,3));
    }

    [TestMethod]
    public void CheckNotTriangle_IfNotTriangle_True()
    {
      TriangleLogic testTriangleLogic = new TriangleLogic();
      Assert.AreEqual(true, testTriangleLogic.IsTriangle(2, 10 ,3));
    }
  }
}