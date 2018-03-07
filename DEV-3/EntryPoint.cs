using System;

namespace NumberRadixConvertion
{
  /// <summary>
  /// It's an entry point in the program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        if (int.Parse(args[1]) < 2 || int.Parse(args[1]) > 20 )
        {
          Console.WriteLine("You entered the base of the new system not from the allowed range");
          return;
        }
        DecimalNumberRadixConvertor convertor = new DecimalNumberRadixConvertor(int.Parse(args[0]));
        Console.WriteLine(convertor.ConvertTo(int.Parse(args[1])));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
