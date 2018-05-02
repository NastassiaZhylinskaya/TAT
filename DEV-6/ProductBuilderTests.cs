using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DEV6;

namespace DEV6.Tests
{
  [TestClass]
  public class ProductBuilderTests
  {
    private const string TYPE = "type";
    private const string NAME = "name";
    private const int COUNT = 1;
    private const double PRICE = 1.0;

    public TestContext TestContext { get; set; }
    private const string connectionStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\DataSources\\ProductBuilderTestsData.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

    [TestMethod]
    [DataSource(connectionStr, "Counts$")]
    [ExpectedException(typeof(Exception))]
    public void Build_ProductWithInvalidCountParameter_Exception()
    {
      int count = Convert.ToInt32(TestContext.DataRow["Negative Count"]);
      var res = new ProductBuilder().Build(TYPE, NAME, count, PRICE);
    }

    [TestMethod]
    [DataSource(connectionStr, "Prices$")]
    public void Build_ProductWithValidPriceParameter_IsProduct()
    {
      double price = Convert.ToDouble(TestContext.DataRow["Positive Price"]);
      var res = new ProductBuilder().Build(TYPE, NAME, COUNT, price);
      Assert.IsInstanceOfType(res, typeof(Product));
    }

    [TestMethod]
    [DataSource(connectionStr, "Prices$")]
    [ExpectedException(typeof(Exception))]
    public void Build_ProductWithInvalidPriceParameter_IsProduct()
    {
      double price = Convert.ToDouble(TestContext.DataRow["Negative Price"]);
      var res = new ProductBuilder().Build(TYPE, NAME, COUNT, price);
    }
  }
}
