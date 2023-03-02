using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace AlertsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            FirefoxOptions capabilities = new FirefoxOptions();
            Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
            browserstackOptions.Add("os", "Windows");
            browserstackOptions.Add("osVersion", "11");
            browserstackOptions.Add("browserVersion", "108.0");
            browserstackOptions.Add("projectName", "KayesProject");
            browserstackOptions.Add("buildName", "1.12345");
            browserstackOptions.Add("sessionName", "Login");
            browserstackOptions.Add("local", "false");
            browserstackOptions.Add("seleniumVersion", "3.10.0");
            browserstackOptions.Add("userName", "USERNAME");
            browserstackOptions.Add("accessKey", "ACCESS_KEY");
            browserstackOptions.Add("browserName", "Firefox");
            capabilities.AddAdditionalOption("bstack:options", browserstackOptions);


            IWebDriver driver = new FirefoxDriver();
            driver.Url="http://demo.guru99.com/test/upload/";


            IWebElement uploadBtn = driver.FindElement(By.Name("uploadfile_0"));
            uploadBtn.SendKeys("C:\\Users\\Emran\\Desktop\\testpic.bmp");

            driver.FindElement(By.Id("terms")).Click();

            driver.FindElement(By.Id("submitbutton")).Click();

            Thread.Sleep(2000);

            Console.WriteLine(driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/form/ul/li/div[2]/h3/center")).Text);


        }
    }
}
