using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace open_tab
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://aquayara.nl/zwemscore-inschrijven/");
          IWebElement elementgender = driver.FindElement(By.Id("geslachtm"));
            elementgender.Click();

            IWebElement dropdwon = driver.FindElement(By.Id("locatie"));
            SelectElement dropdownlist = new SelectElement(dropdwon);
            dropdownlist.SelectByText("Zwemschool Aquayara Tussen de Vaarten B.V.");

            IWebElement elementbetaal = driver.FindElement(By.Id("betaalmethodeo"));
            elementbetaal.Click();
          
        }
    }
}
