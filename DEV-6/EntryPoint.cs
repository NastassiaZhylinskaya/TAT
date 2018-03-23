using System;
using System.Collections.Generic;

namespace DEV6
{
  /// <summary>
  /// It's an entry point in the program.
  /// </summary>
  class EntryPoint
  {
    private const string CHOICE = "Press Esc to end input Products, or any key to continue";
    static void Main(string[] args)
    {
      try
      {
        List<Product> products = new List<Product>();
        ProductBuilder productBuilder = new ProductBuilder();
        ProductParamsInputer productParamsInputer = new ProductParamsInputer();
        StorageCommander storageCommander = new StorageCommander();

        do
        {
          products.Add(productBuilder.Build(productParamsInputer.TypeInput(), productParamsInputer.NameInput(), productParamsInputer.CountInput(), productParamsInputer.PriceInput()));
          Console.WriteLine(CHOICE);
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        storageCommander.Run(products);
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
      Console.ReadKey();
    }
  }
}
