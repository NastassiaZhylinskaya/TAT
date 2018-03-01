using System;

namespace TaskDev1
{
  class EntryPoint
  {
    static void Main(string[] symbolsString)
    {
      if (symbolsString.Length == 1)
      {
        Sequence sequence = new Sequence(symbolsString[0]);
        Console.WriteLine(sequence.FindLongestSameSymbols());
      }
      else
      {
        Console.WriteLine("Wrong arguments.");
      }
    }
  }
}

