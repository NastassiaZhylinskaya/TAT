using System.Collections.Generic;

namespace DEV6
{
  public interface Command
  {
    void execute(List<Product> products, string arg);
  }
}
