using System;
using System.Collections.Generic;

namespace Task_4
{
  /// <summary>
  /// It is entry point in this programm.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        List<Person> persons = new List<Person>();
        PersonsBuilder personsBuilder = new PersonsBuilder();
        PersonParamsInputer input = new PersonParamsInputer();
        PersonCommander personCommander = new PersonCommander();

        do
        {
          persons.Add(personsBuilder.Build(PersonParamsInputer.FirstNameInputer(), PersonParamsInputer.LastNameInputer(), PersonParamsInputer.AgeInputer()));
          Console.WriteLine("Press Esc to end input Persons, or any key to continue");
        } 
        while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        personCommander.Run(persons);
      }
        catch (Exception exc)
      {
        Console.WriteLine(exc.Message);
      }
      Console.ReadKey();      
    }
  }
}
