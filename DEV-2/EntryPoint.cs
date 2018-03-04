using System;
using System.Text;

namespace DEV_2
{
  /// <summary>
  /// It's an entry point in the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
        string currentString = Console.ReadLine();
        EvenIndicesFinder finder  = new EvenIndicesFinder(currentString);
        Console.WriteLine(finder.GetEvenIndices());
    }
  }
}
