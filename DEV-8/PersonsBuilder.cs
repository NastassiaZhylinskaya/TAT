using System;

namespace DEV8
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
    /// <param name="Sex">Sex.</param>
    /// <returns></returns>
    public Person Build(string FirstName, string LastName, int Age, string Sex)
    {
      try
      {
        return new Person(FirstName, LastName, Age, Sex);
      }
      catch (Exception)
      {
        throw new Exception("Person builder error");
      }
    }
  }
}
