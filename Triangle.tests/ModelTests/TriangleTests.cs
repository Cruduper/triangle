using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Model;

namespace Triangle.Test
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleType_IfAllSidesAreEqual_Equilateral()
    {
      TriangleCheck testTriangle = new TriangleCheck();
      Assert.AreEqual("Equilateral", testTriangle.TriangleType(1, 1, 1));
    }

    [TestMethod]
    public void TriangleType_IfTwoSidesAreEqual_Isosceles()
    {
      TriangleCheck testTriangle = new TriangleCheck();
      Assert.AreEqual("Isosceles", testTriangle.TriangleType(2, 2, 3));
    }

    [TestMethod]
    public void TriangleType_OneSideIsGreaterThanSumOfTwoOtherSides_NotATriangle()
    {
      TriangleCheck testTriangle = new TriangleCheck();
      Assert.AreEqual("Not a triangle.", testTriangle.TriangleType(1, 2, 4));
    }

    [TestMethod]
    public void TriangleType_IfNoSidesAreEqual_Scalene()
    {
      TriangleCheck testTriangle = new TriangleCheck();
      Assert.AreEqual("Scalene", testTriangle.TriangleType(1, 2, 3));
    }

  
  }
}