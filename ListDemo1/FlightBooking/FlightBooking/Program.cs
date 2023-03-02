using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;



namespace CheckBoxTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new EdgeDriver();

            driver.Url = "http://uitestpractice.com/Students/Form";

            driver.Manage().Window.Maximize();   // full screen

            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//input[@value='dance']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@value='cricket']")).Click();

        }
    }
}
