using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace SeleniumProject
{
    public class FirstSeleniumProject
    {
       static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();





/*
            
            // we can visit a site in 2 ways:
            //driver.Url = "https://demo.guru99.com/test/newtours/";
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/");



            driver.Manage().Window.Maximize();


            IWebElement flightLink = driver.FindElement(By.LinkText("Flights"));
            flightLink.Click();

            Thread.Sleep(3000);

            // clicking one way:

            IWebElement oneway = driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[2]"));
            oneway.Click();



            driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/font/font/input[2]")).Click();
*/

        }
    }
}
