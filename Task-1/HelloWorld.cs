using System;

namespace Task_1
{
  /// <summary>
  /// Program display inscription and random
  /// number of exclamation points.
  /// </summary>
  class HelloWorld
  {
    static void Main(string[] args)
    {
      int minNumber = 5;
      int maxNumber = 50;

      Random random = new Random();
      int numberOfExclamationPoints = random.Next(minNumber, maxNumber);
      Console.WriteLine("Hello, world!");
      Console.WriteLine("And hi again!");
      for (int i = 1; i < random.Next(minNumber,maxNumber); i++)
      {
        Console.Write("!");
      }
    }
  }
}
