using System;

namespace TaskDev1
{  
  /// <summary>
  /// It's an entry point in the program.
  /// </summary>
  class EntryPoint
  {    
    static void Main(string[] symbolsString)
    { 
      if (symbolsString.Length == 1)
      {
        EqualSymbolsCounter counter = new EqualSymbolsCounter(symbolsString[0]);
        Console.WriteLine(counter.FindSimilarSimbolsSequanceLength());
      }
      else
      {
        Console.WriteLine("Wrong number of arguments.");
      }
    }
  }
 }
