using System;
using System.Collections.Generic;

namespace DEV6.Commands
{
  /// <summary>
  /// Child class of class Command. 
  /// </summary>
  public class HelpCommand : Command
  {
    /// <summary>
    /// This method for help program.
    /// </summary>
    /// <param name="products">Empty products.</param>
    /// <param name="arg">Empty parametr arg.</param>
    public void execute(List<Product> products = null, string arg = null)
    {
      foreach (var command in StorageCommander.Commands)
      {
        Console.WriteLine(command);
      }
    }
  }
}