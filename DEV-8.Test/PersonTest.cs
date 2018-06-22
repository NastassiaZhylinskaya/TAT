using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV8.Test
{
  [TestClass]
  public class PersonTest
  {
    private const string FIRSTNAME = "firstName";
    private const string LASTNAME = "lastName";
    private const int AGE = 0;
    private const string SEX = "sex";

    public TestContext TestContext { get; set; }
    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\PersonTestsData.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr, "Ages$")]
    [ExpectedException(typeof(ArgumentException))]
    public void Build_PersonWithInvalidAgeParameter_Exception()
    {
      int age = Convert.ToInt32(TestContext.DataRow["Negative Age"]);
      var res = new Person(FIRSTNAME, LASTNAME, AGE, SEX);
    }

    [TestMethod]
    [DataSource(connectionStr, "Prices$")]
    public void Build_PersonWithValidAgeParameter_IsProduct()
    {
      int age = Convert.ToInt32(TestContext.DataRow["Negative Age"]);
      var res = new Person(FIRSTNAME, LASTNAME, AGE, SEX);
      Assert.IsInstanceOfType(res, typeof(Person));
    }    
  }
}
