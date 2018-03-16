using System;
using Xunit;
using DEV_2;

namespace DEV_2.Test
{
  public class EvenIndexesStringTest
  {
    [Fact]
    public void TUnEvenStringLengthTestPositive()
    {
      string currentString = "kovalchuk";
      string expected = "kvlhk";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.Equal(expected, actual); 
    }

    [Fact]
    public void EvenStringLengthTestPositive()
    {
      string currentString = "kovalchukk";
      string expected = "kvlhk";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void NullStringLengthPositive()
    {
      string currentString = "";
      string expected = "";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void OneStringLengthPositive()
    {
      string currentString = "a";
      string expected = "a";
      EvenIndexesString stringCreator = new EvenIndexesString();
      string actual = stringCreator.CreateEvenIndexesString(currentString);
      Assert.Equal(expected, actual);
    }
  }
}
