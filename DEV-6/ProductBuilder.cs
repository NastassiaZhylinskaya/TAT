using System;

namespace DEV6
{
  /// <summary>
  /// Product builder class.
  /// </summary>
  public class ProductBuilder
  {
    private const string BUILD_ERROR = "Product building error";

    /// <summary>
    /// For product build.
    /// </summary>
    /// <param name="type">type.</param>
    /// <param name="name">name.</param>
    /// <param name="count">count.</param>
    /// <param name="price">price.</param>
    /// <returns></returns>
    public Product Build(string type, string name, int count, double price)
    {
      try
      {
        return new Product(type, name, count, price);
      }
      catch (Exception)
      {
        throw new Exception(BUILD_ERROR);
      }
    }
  }
}