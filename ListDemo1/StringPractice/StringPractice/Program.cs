using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // string is (i) a sequence of characters: "hasan"   - (ii) must be enclosed by " "

            
            // string variable declaration: 1st way
            string city = "new york city";

            string city1 = "Washington D. C.";


            string desc = "dgvfbhhn gdfhfj tryh rt wreftgrht nj fsad bn hfgj fgdsfd g";

            string name = "HASAN";
            Console.WriteLine(name[0]);


            // declaration of an empty string:
            string emptyString = "";


            string char1 = "A";                  // please note the double quotes: string
            Console.WriteLine(char1);
            Console.WriteLine(char1.GetType());


            char char2 = 'A';                   // please note the single quotes: char
            Console.WriteLine(char2);
            Console.WriteLine(char2.GetType());



            string splchar = ">";

            string aNum = "100";   
            string bNum = "300";
            Console.WriteLine(aNum + bNum);  // they are now placed side-by-side
                                             // no arithmetica sum happened

            // declare two variables:

            string gasPrice1 = "3.99";
            string gasPrice2 = "4.99";

            Console.WriteLine(gasPrice1 + gasPrice2);

            // string or String are the same and both represent String class under System
            String gasPrice3 = "5.19";


             
            // make it upper case:
            string myName = "sakib";
            Console.WriteLine(myName.ToUpper());

            // make it lower case:
            string yourName = "SOLAIMAN";

            Console.WriteLine(yourName.ToLower());  // here ToLower is a function, so () required

            Console.WriteLine(yourName.Length);  // here Length is a Property, so no () required


            // declaring a string with a white-space only

            string whiteSpace = " ";


            string password = "$#jn^region%L(&^%!";

            Console.WriteLine(password);




            // string variable declaration: 2nd way
            
            char[] letters = { 'l', 'i', 'l', 'y' };



        //  String: class
        // flower: string variable name
        // = assignment operator 
        // new: keyword
        // String(): String class construct

            String flower = new String(letters);

            Console.WriteLine(flower);


            // any string variable respresents the properties of the String class

          
            // please practice: 
            string car = "toyoytay";
            Console.WriteLine(car.IndexOf('y'));
            Console.WriteLine(car.LastIndexOf('o'));

            

            Console.WriteLine(car.Replace('t', 'T'));


            // preceeding (leading) spaces and trailing spaces
            string spaces = "               new york city       ";

            Console.WriteLine(spaces);

            Console.WriteLine(spaces.Trim());


            string name1 = "                    rafi                    ";
            Console.WriteLine(name1);

            Console.WriteLine(name1.TrimStart());

            // please use TrimEnd() to remove space from the end:
            Console.WriteLine(name1.TrimEnd());


            // how to convert an int to a string using ToString()
            int number = 123;
            Console.WriteLine(number.ToString().GetType());  // an example of function chaining



            // concat()  <- concatenation (joining two or more strings):

            // 2 ways to concatenate string: (a) using concat() and (b) using + operator
            string fname = "Donald ";
            string lname = "Trump";
            string fullname = String.Concat(fname, lname);
            Console.WriteLine(fullname);


            string first = "joe ";
            string last = "biden";

            Console.WriteLine(first + last);



            string descrip = "we are learning C# but we need to speed up";

            Console.WriteLine(descrip.Contains("Java"));   // checks if a substring is present inside - True / False

            Console.WriteLine(descrip.StartsWith("we"));
            Console.WriteLine(descrip.EndsWith("up"));




            string vegetables = "potato";
            Console.WriteLine("I like "                        +                           vegetables  +   " very much!");



            int x = 10, y = 20;

            Console.WriteLine("the sum of " 
                + x + 
                " and " 
                + y + 
                " is " + 
                (x + y));




            string i = "john";
            int age = 20;

            Console.WriteLine("I am " + i + " and I am " + age + " years old!");

            // "My name is"  + i  + " " + " and I am" + age + " years old"


            // Task: Print your name and roll number and using + operator


            String MyName = "Mohammed Emran"; 
            int roll = 420; 
            Console.WriteLine("my name is " +MyName + " and my roll number is " +roll);




            // String manipulation: all string operations and functions


            string rest = "we need some rest";

//            string[] brokenparts = rest.Split(' ');  // Split() breaks a string into array of sub-strings


            foreach(string we in rest.Split(' '))
            {

                    Console.WriteLine(we);

            }

        }
    }
}
