using System;

namespace TaskDev1
{
  /// <summary>
  /// This class for work with string and
  /// count max length of equal symbols.
  /// </summary>
  class EqualSymbolsCounter
  {
    /// <summary>
    /// This method gets console arguments.
    /// </summary>
    public EqualSymbolsCounter(string ourString)
    {  
       currentString = ourString;
    }
    private string currentString;
    /// <summary>
    /// This method for find max length same symbols.
    /// </summary>
    /// <returns>Returns the maximum number duplicate successive symbols.</returns>
    public int FindSimilarSimbolsSequanceLength()
    {  
       int maxSameStringLength = 1;
       int currentSequenceLength = 1;   
       for (int i = 0; i < currentString.Length - 1; i++)
       {        
         if (currentString[i] == currentString[i + 1])
         { 
           currentSequenceLength++;
         }
         else
         {
           currentSequenceLength = 1;
         }
         if (maxSameStringLength < currentSequenceLength)
         {
           maxSameStringLength = currentSequenceLength;
         }                
       } 
     return maxSameStringLength;
    }
  }
}
