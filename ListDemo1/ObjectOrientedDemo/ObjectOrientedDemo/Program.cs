using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ObjectOrientedDemo
{

    public abstract class Sarowar
    {

        public abstract void WeAreLazy();

        public static void getTitle()
        {
            Console.WriteLine("I am the title");

        }


    }

    public class Program    {




        public static void Main(String[] kazinoyonahmed)
        {


            int[] inArray = new int[4] { 1, 2, 3, 4 };

            List numList = new List() { 1, 2, 3, 4 };



            Object n1 = 26;
            Console.WriteLine(n1.GetType());


       

            Console.WriteLine(getName("kayes", "uddin"));

        }

        public static string getName(string firstName, string lastName)
        {

            return firstName + " " + lastName;
        }





    }
 

}




