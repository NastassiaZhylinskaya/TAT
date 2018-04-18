using System;
using System.Collections.Generic;

namespace DEV8
{
  /// <summary>
  /// Class for input person parametrs.
  /// </summary>
  public class PersonParamsInputer
  {
    public static string FirstNameInputer()
    {
      Console.WriteLine("Input person first name: ");
      return Console.ReadLine();
    }

    public static string LastNameInputer()
    {
      Console.WriteLine("Input person last name: ");
      return Console.ReadLine();
    }
    public static int AgeInputer()
    {
      Console.WriteLine("Input person age: ");
      return int.Parse(Console.ReadLine());
    }
    public static string SexInputer()
    {
      Console.WriteLine("Input person sex: ");
      return Console.ReadLine();
    }    
  }
}
