using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_2.Test
{
  [TestClass]
  public class EvenIndexesStringTest
  {
    [TestMethod]
    public void UnEvenStringLengthTestPositive()
    {
      string currentString = "kovalchuk";
      string expected = "kvlhk";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.AreEqual(expected, actual);      
    }

    [TestMethod]
    public void EvenStringLengthTestPositive()
    {
      string currentString = "kovalchukk";
      string expected = "kvlhk";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void NullStringLengthPositive()
    {
      string currentString = "";
      string expected = "";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void OneStringLengthPositive()
    {
      string currentString = "a";
      string expected = "a";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.AreEqual(expected, actual);
    }
  }
}
