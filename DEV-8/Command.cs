using System.Collections.Generic;

namespace DEV8
{
  /// <summary>
  /// Method for pattern Command.
  /// </summary>
  public interface Command
  {
    void execute(List<Person> products, string arg);
  }
}
