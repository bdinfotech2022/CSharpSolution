using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace SeleniumAutomation1
{

    class TestFile
    {

        public static void Main(string[] args)
        {

            IWebDriver driver = new FirefoxDriver();



            driver.Navigate().GoToUrl("https://www.guru99.com/");


            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.Manage().Window.FullScreen();
      
         
            driver.Navigate().GoToUrl("https://www.guru99.com/");
            Console.WriteLine("Guru99 homepage handle: " + driver.CurrentWindowHandle);
            Console.Beep();
            
            driver.FindElement(By.PartialLinkText("Live Selenium Project")).Click();
            Console.Beep();
            Console.WriteLine("Live Selenium Project: " + driver.CurrentWindowHandle);


            driver.FindElement(By.ClassName("kt-blocks-info-box-title")).Click();
            Console.WriteLine("sql: " + driver.CurrentWindowHandle);
            driver.Navigate().Refresh();

            List<string> listOfWindowHandles = driver.WindowHandles.ToList<string>();


          //   for mouse action: we need to import this: using OpenQA.Selenium.Interactions;
            IWebElement clickable = driver.FindElement(By.Id("clickable"));
            new Actions(driver).ClickAndHold(clickable).Perform();
         
        }
    }
}
