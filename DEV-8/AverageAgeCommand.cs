using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV8
{
  /// <summary>
  /// Child class of class Command.
  /// </summary>
  public class AverageAgeCommand : Command
  {
    /// <summary>
    /// This method for count average age of program persons.
    /// </summary>
    /// <param name="persons">List.</Person></param>
    /// <param name="arg">Inputted value.</param>
    public void execute(List<Person> persons, string arg = null)
    {
      if (!persons.Any())
      {
        throw new ArgumentNullException();
      }
      double average = 0.0;
      foreach(var Person in persons)
      {
        average = persons.Average(per => per.Age);
      }
      Console.WriteLine("Average age is: {0}", average);
    }  
  }
}
