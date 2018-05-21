using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2;

namespace Task_2.Test
{  
  [TestClass]
  public class AreaCalculatorTest
  {       
    [TestMethod]
    public void PositiveValidValueTest()
    {
      int width = 5;
      int length = 6;
      int expected = 30;
      AreaCalculator calculator = new AreaCalculator(width, length);
      Assert.AreEqual(expected, calculator.Calculate(width, length));
    }
  }
}
