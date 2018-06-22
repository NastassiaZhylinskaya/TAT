using System.Collections.Generic;

namespace Task_4
{
  /// <summary>
  /// Method for pattern Command.
  /// </summary>
  public interface Command
  {
    void execute(List<Person> products, string arg);
  }
}
