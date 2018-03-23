using System;

namespace NumberRadixConvertion
{
  /// <summary>
  /// It's an entry point in the program.
  /// </summary>
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      int basisOfANewNumeralSystem = int.Parse(args[1]);
      int sourceNumber = int.Parse(args[0]);
      try
      {
        if (basisOfANewNumeralSystem < 2 || basisOfANewNumeralSystem > 20)
        {
          Console.WriteLine("You entered the base of the new system not from the allowed range");
          return;
        }      
        DecimalNumberRadixConvertor convertor = new DecimalNumberRadixConvertor(sourceNumber);
        Console.WriteLine(convertor.ConvertTo(basisOfANewNumeralSystem));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
