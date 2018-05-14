using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV8
{
  /// <summary>
  /// Child class of class Command.
  /// </summary>
 public class OldestUserCommand : Command
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
      int oldestUser = 0;
      foreach(var Person in persons)
      {
        oldestUser = persons.Max(per => per.Age);        
      }
      Console.WriteLine("Age of the oldest person is: {0}", oldestUser);
    }
  }
}
