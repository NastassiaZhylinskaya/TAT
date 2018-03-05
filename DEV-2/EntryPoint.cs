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
      string currentString = Console.ReadLine();
      while (currentString.Length == 0)
      {
        Console.WriteLine("String length is null, repeat please.");
        currentString = Console.ReadLine();
      }
      StringBuilder newStringBuilder = new StringBuilder();
      for (int i = 0; i < currentString.Length; i += 2)
      {
        newStringBuilder.Append(currentString[i]);
      }
      Console.WriteLine(newStringBuilder);
    }
  }
}
