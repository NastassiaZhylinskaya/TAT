using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Dev9
{
  class NewsPage
  {
    IWebDriver driver = new ChromeDriver();
    public void MessagesPage()
    {
      driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      if (driver.Url != "https://vk.com/feed")
      {
        throw new Exception("This is not registration page");
      }      
      IWebElement element = driver.FindElement(By.XPath("//li[@id='l_msg']"));
      element.Click();
    }
  }
}
