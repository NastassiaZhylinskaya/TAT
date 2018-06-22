using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_4
{
  /// <summary>
  /// Child class of class Command.
  /// </summary>
  public class YoungestUserCommand : Command
  {
    /// <summary>
    /// Method for find oldest user in list.
    /// </summary>
    /// <param name="persons">List.</param>
    /// <param name="arg">Inputted value.</param>
    public void execute(List<Person> persons, string arg = null)
    {
      if (!persons.Any())
      {
        throw new ArgumentNullException();
      }
      int youngestUser = 0;
      foreach (var Person in persons)
      {
        youngestUser = persons.Min(per => per.Age);
      }
      Console.WriteLine("Age of the youngest person is: {0}", youngestUser);
    }
  }
}
