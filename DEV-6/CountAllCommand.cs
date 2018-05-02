using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV6.Commands
{
  /// <summary>
  /// Child class of class Command.
  /// </summary>
  public class CountAllCommand : Command
  {
    /// <summary>
    /// Method for count all types product.
    /// </summary>
    /// <param name="products">Products.</param>
    /// <param name="arg">Parametr arg.</param>
    public void execute(List<Product> products, string arg = null)
    {
      if (!products.Any())
      {
        throw new ArgumentNullException();
      }
      int count = 0;
      foreach (var product in products)
      {
        count += product.Count;
      }
      Console.WriteLine(count);
    }
  }
}