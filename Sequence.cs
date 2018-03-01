using System;

namespace TaskDev1
{
  class Sequence
  {  
    private string currentString;
   
    public int FindLongestSameSymbols()
    {
      int maxSameStringLength = 0;
      int counter = 0;
      char theFirstSymbol = currentString[0];
      for (int i = 0; i < currentString.Length - 1; i++)
      {
        if (theFirstSymbol == currentString[i + 1])
        {
          counter++;
        }
        else
        {
          theFirstSymbol = currentString[i + 1];
          counter = 0;
        }
        if (maxSameStringLength < counter)
        {
          maxSameStringLength = counter;
        }
      } 
     return maxSameStringLength;
    }
         
    public Sequence(string ourString)
    {
      currentString = ourString;
    }
  }
}
