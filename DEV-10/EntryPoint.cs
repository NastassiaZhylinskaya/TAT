using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace CarBMW
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      try
      {
        ChromeDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://av.by");
        driver.Manage().Window.Maximize();
        HomePage homePage = new HomePage(driver);        
        homePage.ChooseMark(args[0]);
        homePage.SetModelList();

        List<Car> cars = homePage.GetModelList();
        foreach (Car car in cars)
        {
          Console.WriteLine(car);
        }
        driver.Quit();        
      }      
      catch (NoSuchElementException ex)
      {
        Console.WriteLine(ex.Message);
      }      
    }
  }
}
