using System;
using System.Text;

namespace DEV_2
{
  /// <summary>
  /// This class works with strings and
  /// find even indices on the string.
  /// </summary>
  class EvenIndicesFinder
  {
    public string currentString;
    public EvenIndicesFinder(string ourString)
    {
      currentString = ourString;
    }
    /// <summary>
    /// This method get even indices of the string
    /// and create a new string.
    /// </summary>
    /// <returns></returns>
    public string GetEvenIndices()
    {
      StringBuilder newString = new StringBuilder();
      for (int i = 0; i < currentString.Length; i = i + 2)
      {
        newString.Append(currentString[i]);
      }
      return newString.ToString();
    }
  }
}
