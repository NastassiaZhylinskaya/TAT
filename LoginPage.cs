using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dev9
{
  class LoginPage
  {
    IWebDriver driver = new ChromeDriver();        
    public void NewsPage(string login, string password)
    {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      
      //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      driver.Url = "https://vk.com/";
      if (driver.Url != "https://vk.com/")
      {
        throw new Exception("This is not registration page");
      }
      driver.FindElement(By.Id("index_email")).SendKeys(login); 
      driver.FindElement(By.Id("index_pass")).SendKeys(password + Keys.Enter);          
    }          
  }
}
