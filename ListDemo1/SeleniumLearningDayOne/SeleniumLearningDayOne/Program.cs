using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Interactions;


namespace SeleniumLearningDayOne
{
    public class Program
    {
        static void Main(string[] args)
        {


            IWebDriver driver = new ChromeDriver();
            Actions act = new Actions(driver);

            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";

            IWebElement firstname = driver.FindElement(By.Name("firstName"));
            IWebElement lastname = driver.FindElement(By.Name("lastName"));

            Thread.Sleep(3000);

            // cut:
            act.SendKeys(lastname, "Rafiullah")
               .KeyDown(Keys.Shift).SendKeys(Keys.ArrowUp)  // <-- Select the name
               .KeyUp(Keys.Shift)                           // <-- release shift
               .KeyDown(Keys.Control)                       // <-- press Ctrl
               .SendKeys("x")                               // <-- press Ctrl+x (cut)    
               .SendKeys(firstname, "v")                    // <-- Ctrl+v (paste) in firstname
              
               .Perform();


            //paste:
            firstname.SendKeys("Rafiullah");


            /*  
            *  driver.Manage().Window.Maximize();

            IWebElement from = driver.FindElement(By.Id("draggable"));
  
            Thread.Sleep(3000);
            act.DragAndDropToOffset(from, 150, 150).Perform();





           
                         IWebDriver driver = new ChromeDriver();
            Actions act = new Actions(driver);
           

            driver.Navigate().GoToUrl("https://selenium.dev/selenium/web/mouse_interaction.html");

            IWebElement hoverElem = driver.FindElement(By.Id("hover"));


            Thread.Sleep(5000);
            act.MoveToElement(hoverElem).Perform();


            string status = driver.FindElement(By.Id("move-status")).Text;
            Console.WriteLine("The status is : " + status);     
            
            IWebElement ctxBtn = driver.FindElement(By.XPath("/html/body/div/section/div/div/div/p/span"));
                        Thread.Sleep(1500);
                        act.ContextClick(ctxBtn).Perform();

                        Thread.Sleep(3000);

                        IWebElement quit = driver.FindElement(By.XPath("/html/body/ul/li[7]"));
                        act.Click(quit).Perform();


                        Thread.Sleep(5000);
                        driver.Quit();


                           IWebDriver driver = new ChromeDriver();
                        Actions act = new Actions(driver);

                        driver.Url = "http://www.uitestpractice.com/Students/Actions";

                        driver.Manage().Window.Maximize();

                        IWebElement from = driver.FindElement(By.Id("draggable"));
                        IWebElement to = driver.FindElement(By.Id("droppable"));

                        Thread.Sleep(3000);
                        act.DragAndDrop(from, to).Perform();




                        Thread.Sleep(5000);
                        driver.Quit();




                                 IWebDriver driver = new ChromeDriver();
                                 Actions act = new Actions(driver);


                                 driver.Url = "https://selenium.dev/selenium/web/mouse_interaction.html";

                                 IWebElement hoverElement = driver.FindElement(By.Id("hover"));
                                 Thread.Sleep(3000);
                                 act.MoveToElement(hoverElement).Perform();

                                 Thread.Sleep(3000);


                                 driver.Quit();

                                 // From element 
                                 IWebElement source = driver.FindElement(By.Id("draggable"));

                                 // To element 
                                IWebElement target = driver.FindElement(By.Id("droppable"));
                                 Thread.Sleep(3000);

                                 // perfrom drag and drop action:
                                 act.DragAndDrop(source, target).Perform();

                             //    Console.WriteLine(driver.FindElement(By.XPath("//*[@id='droppable']/p")).Text);    
                                 Thread.Sleep(3000);

                                 driver.Quit();



                                             // declaring the object of the Action class
                                             Actions act = new Actions(driver);

                                             // driver.Url = "https://selenium.dev/selenium/web/mouse_interaction.html";
                                             driver.Navigate().GoToUrl("http://www.uitestpractice.com/");

                                             driver.Manage().Window.Maximize();

                                             Thread.Sleep(3000);


                                             IWebElement dblClickable = driver.FindElement(By.Name("dblClick"));

                                             act.DoubleClick(dblClickable).Perform();


                                             Thread.Sleep(3000);










                                             driver.Url = "http://uitestpractice.com/Students/Form";
                                             //Thread.Sleep(1000);

                                             driver.Manage().Window.Maximize();
                                             //Thread.Sleep(1000);

                                             IWebElement firstName = driver.FindElement(By.Id("firstname"));
                                             firstName.SendKeys("Michel");
                                             Thread.Sleep(1000);

                                             IWebElement lastName = driver.FindElement(By.Id("lastname"));
                                             lastName.SendKeys("Jackson");
                                             Thread.Sleep(1000);

                                             IWebElement marital = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/form/div[3]/label[4]/input"));
                                             marital.Click();
                                             Thread.Sleep(1000);


                                             IWebElement hobby = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/form/div[4]/label[4]/input"));
                                             hobby.Click();
                                             Thread.Sleep(1000);


                                             IWebElement countrySelector = driver.FindElement(By.Id("sel1"));
                                             SelectElement country = new SelectElement(countrySelector);
                                             country.SelectByText("Canada");
                                             Thread.Sleep(1000);

                                             IWebElement dateofbirth = driver.FindElement(By.XPath("//*[@id=\"datepicker\"]"));
                                             dateofbirth.Click();
                                             Thread.Sleep(1000);

                                             IWebElement monthSelector = driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/div/div/select[1]"));
                                             SelectElement month = new SelectElement(monthSelector);
                                             month.SelectByText("Feb");
                                             Thread.Sleep(1000);


                                             IWebElement yearSelector = driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/div/div/select[2]"));
                                             SelectElement year = new SelectElement(yearSelector);
                                             year.SelectByText("1979");
                                             Thread.Sleep(1000);

                                             IWebElement daySelector = driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/table/tbody/tr[1]/td[5]/a"));
                                             daySelector.Click();
                                             Thread.Sleep(1000);

                                             IWebElement phoneNumber = driver.FindElement(By.Id("phonenumber"));
                                             phoneNumber.SendKeys("6469251934");
                                             Thread.Sleep(1000);

                                             IWebElement userName = driver.FindElement(By.Id("username"));
                                             userName.SendKeys("Solaiman");
                                             Thread.Sleep(1000);

                                             IWebElement email = driver.FindElement(By.Id("email"));
                                             email.SendKeys("Solaiman@bdtech.com");
                                             Thread.Sleep(1000);

                                             IWebElement abut = driver.FindElement(By.Id("comment"));
                                             abut.SendKeys("Hi every one we are learning Selenium");
                                             Thread.Sleep(1000);

                                             IWebElement password = driver.FindElement(By.Id("pwd"));
                                             password.SendKeys("1234");


                                             IWebElement submit = driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/form/div[12]/div/button"));
                                             submit.Click();



                                             // Selenium: used to automate web applications (we pages)
                                             // 1. Launch the browser
                                             IWebDriver driver = new ChromeDriver();

                                             // 2. go to google.com
                                             driver.Url = "https://www.google.com/";

                                             // 3. search box: fifa world cup
                                             IWebElement inputBox = driver.FindElement(By.Name("q"));
                                             inputBox.SendKeys("fifa world cup");

                                             // 4. press Enter in the search button
                                             IWebElement srcBtn = driver.FindElement(By.ClassName("gLFyf"));
                                             srcBtn.Submit();

                                             Thread.Sleep(3000);
                                             */
        }
    }
}
