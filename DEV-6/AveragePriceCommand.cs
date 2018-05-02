using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV6.Commands
{ 
  /// <summary>
  /// Single class for commands
  /// "average price" and "average price type"
  /// </summary>
  public class AveragePriceCommand : Command
  {
    private const string PRODUCTS_NOT_FOUND = "Not found such product. Displayed average price";

    /// <summary>
    /// Method search type of product in parameter args
    /// </summary>
    public void execute(List<Product> products, string arg = null)
    {
      if (!products.Any())
      {
        throw new ArgumentNullException();
      }
      double result = 0.0;
      var tempProductsList = products;
     
      if (arg.Any() && products.Exists(product => product.Type.Equals(arg)))
      {
        tempProductsList = products.FindAll(product => product.Type.Equals(arg));
      }
      if (arg.Any() && !(products.Exists(product => product.Type.Equals(arg))))
      {
        Console.WriteLine(PRODUCTS_NOT_FOUND);
      }
      
      foreach (var product in tempProductsList)
      {
        result += product.Price;
      }
      Console.WriteLine(result / tempProductsList.Count);
    }
  }
}