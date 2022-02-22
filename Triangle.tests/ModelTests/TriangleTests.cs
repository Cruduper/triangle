using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Test
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_AIsGreaterThanBPlusC_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(1, 1, 1));
    }
  }
}
  // public void IsLeapYear_NumberDivisibleByFour_True()
  //   {
  //     LeapYear testLeapYear = new LeapYear();
  //     Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
  //   }
...

// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }

// ...