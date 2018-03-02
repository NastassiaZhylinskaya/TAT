using System;

namespace TaskDev1
{
  class EntryPoint
  {
    static void Main(string[] symbolsString)
    {
      if (symbolsString.Length == 1)
      {
        SequenceOfString sequence = new SequenceOfString(symbolsString[0]);
        Console.WriteLine(sequence.FindMaxLengthSameSymbols());
      }
      else
      {
        Console.WriteLine("Wrong number of arguments.");
      }
    }
  }
}

