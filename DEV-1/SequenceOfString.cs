using System;

namespace TaskDev1
{
  /// <summary>
  /// This class for work with string and
  /// find max length same symbols.
  /// </summary>
  class SequenceOfString
  {  
    private string currentString;
   /// <summary>
   /// This method for find max length same symbols.
   /// </summary>
   /// <returns>Return the response to the task.</returns>
    public int FindMaxLengthSameSymbols()
    {
      int maxSameStringLength = 0;
      int currentSequenceLength = 0;
      char theFirstSymbol = currentString[0];
      for (int i = 0; i < currentString.Length - 1; i++)
      {
        if (theFirstSymbol == currentString[i + 1])
        {
          currentSequenceLength++;
          if (maxSameStringLength < currentSequenceLength)
          {
            maxSameStringLength = currentSequenceLength;
          }
        }
        else
        {
          theFirstSymbol = currentString[i + 1];
          currentSequenceLength = 0;
        }        
      } 
     return maxSameStringLength;
    }    
    /// <summary>
    /// This method gets console arguments.
    /// </summary>
    /// <param name="ourString">return our string.</param>     
    public SequenceOfString(string ourString)
    {
      currentString = ourString;
    }
  }
}
