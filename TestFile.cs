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

<<<<<<< HEAD
        // comment: from The Ramesh! Hi There!
        // comment: from The Ramesh! Hi There!


        // I am learning new thing like Git!

=======
        // comment: Zakir bhai good morning
>>>>>>> 9f4d55f6f8235c0d36120e387dcb1d5ac8f93f6d

        public static int SSN;


        public static void Test(string[] args)
        {

            int x = 20;
            int y = 30;
            int sum = x + y;
            Console.WriteLine(sum);


            // kayes added these

            int n1 = 100, n2 = 200;


            // My name Nayon
            // I am lerning

            //my name is sarowar - welcome to Github collaboration! :)
            //I am very expert in this field


            // int myNum = 100;




            // this changes are being made from Github





            
            string desc = "commit korar pore kotahy jabo";

            int num = 20;
            string name = "mitu";

            IWebDriver driver = new FirefoxDriver();

            // I am larning
            // string 
            driver.Navigate().GoToUrl("https://www.guru99.com/");

            // Today is Sunday
            // I am came in the class at 10 am

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


            driver.Navigate().GoToUrl("https://www.guru99.com/");
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Navigate().GoToUrl("https://www.yahoo.com/");
            

            //Rahat - Github commit for the first time


        }
    }
}
