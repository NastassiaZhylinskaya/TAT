using System;

namespace DEV8
{
  public class Person
  {    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }  
    
    public Person(string firstName, string lastName, int age, string sex)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Age = age;
      this.Sex = sex;
    }
    public override string ToString()
    {
      return FirstName + " " + LastName + " " + Age + " " + Sex;
    }
  }
}
