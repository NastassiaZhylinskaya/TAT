using System;
using System.Text;

namespace DEV_2
{
  /// <summary>
  /// This class creates the string with with even indexes.
  /// </summary>
  public class EvenIndexesString
  {
    /// <summary>
    /// This method creates the string with even indexes.
    /// </summary>
    /// <param name="currentString"></param>
    /// <returns></returns>
    public string CreateEvenIndexesString(string currentString)
    {
      StringBuilder result = new StringBuilder();
      for (int i = 0; i < currentString.Length; i += 2)
      {
        result.Append(currentString[i]);
      }
      return result.ToString();
    }
  }
}
