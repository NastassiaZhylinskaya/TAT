using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV6.Commands
{
  /// <summary>
  /// Child class of class Command.
  /// </summary>
  public class CountTypesCommand : Command
  {
    /// <summary>
    /// This method for count types products.
    /// </summary>
    /// <param name="products">Products.</param>
    /// <param name="arg">Parametr arg.</param>
    public void execute(List<Product> products, string arg = null)
    {
      if (!products.Any())
      {
        throw new ArgumentNullException();
      }
      HashSet<string> types = new HashSet<string>();
      foreach (var product in products)
      {
        types.Add(product.Type);
      }
      Console.WriteLine(types.Count);
    }

  }
}