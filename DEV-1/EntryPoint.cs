using System;

namespace TaskDev1
{
  /// <summary>
  /// This class for print information about
  /// max length same symbols and inputed arguments command line.
  /// </summary>
  class EntryPoint
  {
    /// <summary>
    /// This method print information.
    /// </summary>
    /// <param name="symbolsString">String which inputed in arguments command line.</param>
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

