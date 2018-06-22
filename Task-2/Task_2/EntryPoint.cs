using System;

namespace Task_2
{
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      int length = int.Parse(args[0]);
      int width = int.Parse(args[1]);

      try
      {
        if (length < 0 || width <0 )
        {
          Console.WriteLine("You entered a negative value.");
          return;
        }

        if (length > int.MaxValue || width > int.MaxValue)
        {
          Console.WriteLine("You entered too much value.");
          return;
        }

        if (0 == length || 0 == width)
        {
          Console.WriteLine("You entered zero value.");
        }

        AreaCalculator calculator = new AreaCalculator(width, length);
        calculator.Calculate(width,length);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
