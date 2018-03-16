using NUnit.Framework;
using System;
using NumberRadixConvertion;

namespace DEV_3.Test
{
  [TestFixture]
  public class DecimalNumberRadixConvertorTest
  {
    
    [TestCase(286,18,"FG")]
    [TestCase(20,20,"10")]
    [TestCase(0,0,"0")]
    [Test]
    public void PositiveValidValueTest(int sourceNumber, int radix, string expected)
    {
      DecimalNumberRadixConvertor convertor = new DecimalNumberRadixConvertor(sourceNumber);
      Assert.AreEqual(expected, convertor.ConvertTo(radix));
    }

    [TestCase(1)]
    [TestCase(21)]
    [Test]
    public void NegativeSourceNumberTest(int errorSource)
    {
      DecimalNumberRadixConvertor convertor = new DecimalNumberRadixConvertor(errorSource);
      Assert.Throws<ArgumentException>(() => convertor.ConvertTo(errorSource));
    }

    [TestCase(-286,18)]
    public void  NegativeSourceNumberTest(int sourceNumber, int radix)
    {
      DecimalNumberRadixConvertor convertor = new DecimalNumberRadixConvertor(sourceNumber);
      Assert.Throws<ArgumentException>(() => convertor.ConvertTo(radix));
    }
  }
}
