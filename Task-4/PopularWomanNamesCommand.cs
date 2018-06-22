using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV8
{
  /// <summary>
  /// Child class of class Command.
  /// </summary>
  public class PopularWomanNamesCommand : Command
  {
    private string result;
    /// <summary>
    /// Method for search popular woman names.
    /// </summary>
    /// <param name="persons">List.</param>
    /// <param name="arg">Inputted value.</param>
    public void execute(List<Person> persons, string arg = null)
    {      
      if (!persons.Any())
      {
        throw new ArgumentNullException();
      }
      var popularWomanName = from per in persons
          where per.Sex == "female"
          select per;    
      int qtyMax = 0;
      int qty;

      foreach (var popularName in popularWomanName)
      {
        qty = popularWomanName.Count(p => p.FirstName.Equals(popularName.FirstName));
        if (qtyMax < qty)
        {
          qtyMax = qty;
          result = popularName.FirstName;
        }
      }
      Console.WriteLine("The most popular woman name is: {0}", result);
    }
  }
}
