using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV8.Test
{
  [TestClass]
  public class PersonBuilderTest
  {
    private const string FIRSTNAME = "firstName";
    private const string LASTNAME = "lastName";
    private const int AGE = 0;
    private const string SEX = "sex";

    public TestContext TestContext { get; set; }
    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\PersonsBuilderTestsData.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr, "Ages$")]
    [ExpectedException(typeof(Exception))]
    public void Build_PersonWithInvalidAgetParameter_Exception()
    {
      int age = Convert.ToInt32(TestContext.DataRow["Negative Age"]);
      var res = new PersonsBuilder().Build(FIRSTNAME, LASTNAME, AGE, SEX);
    }

    [TestMethod]
    [DataSource(connectionStr, "Ages$")]
    public void Build_PersonWithValidSexParameter_IsPerson()
    {
      int age = Convert.ToInt32(TestContext.DataRow["Exception Age"]);
      var res = new PersonsBuilder().Build(FIRSTNAME, LASTNAME, AGE, SEX);
      Assert.IsInstanceOfType(res, typeof(Person));
    }   
  }
}
