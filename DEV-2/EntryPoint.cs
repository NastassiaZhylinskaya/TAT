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
      Console.WriteLine("Enter your string:");
      string currentString;
      do
      {
        currentString = Console.ReadLine();
        if (currentString == string.Empty)
        {
          Console.WriteLine("String length is null, repeat please.");
        }
      }
      while (currentString == string.Empty);      
      EvenIndexesString finder = new EvenIndexesString();
      Console.WriteLine(finder.CreateEvenIndexesString(currentString));
    }
  }
}
