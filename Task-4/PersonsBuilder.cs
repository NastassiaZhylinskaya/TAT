using System;

namespace Task_4
{
  /// <summary>
  /// Person builder class.
  /// </summary>
  public class PersonsBuilder
  {
    /// <summary>
    /// For person build.
    /// </summary>
    /// <param name="FirstName">FirstName.</param>
    /// <param name="LastName">LastName.</param>
    /// <param name="Age">Age.</param>   
    /// <returns></returns>
    public Person Build(string FirstName, string LastName, int Age)
    {
      try
      {
        return new Person(FirstName, LastName, Age);
      }
      catch (Exception)
      {
        throw new Exception("Person builder error");
      }
    }
  }
}
