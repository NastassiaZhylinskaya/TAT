using System;
using System.Collections.Generic;

namespace DEV6.Commands
{
  /// <summary>
  /// Child class of class Command.
  /// </summary>
  public class ExitCommand : Command
  {
    private const string GOODBYE = "Goodbye!";
    /// <summary>
    /// This method for exit program.
    /// </summary>
    /// <param name="products">Empty products.</param>
    /// <param name="arg">Empty parametr arg.</param>
    public void execute(List<Product> products = null, string arg = null)
    {
      Console.WriteLine(GOODBYE);
      Environment.Exit(0);
    }
  }
}