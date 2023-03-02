using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuProject   
{
   class Program    
    {
        // when a variable is outside a method: global variable or field
        
        string color = "green";   // non-static field: no static keyword
        static int num = 100;    // static field: it has static keyword


        public void printName()    // non-static mehton - no static keyword
        {
            Console.WriteLine("my name is khan");

        }

        public static string Learning()
        {
            return "We are learning C#";
        }

        static void Main(string[] args) 
        {
            string name = "nyc";         // <-- when a variable is inside a method: local variable

            Console.WriteLine(num);   // num is static so we can print direct in static Main()  

            // object / class object (copy) / class instance:  all are the same:
            Program obj = new Program();
            Console.WriteLine(obj.color);
            Console.WriteLine(obj.color);

            obj.printName();

            Console.WriteLine(Learning());
        }


        public static string getName(string[] student)
        {

            string[] students = { "rafi", "sujon", "farhad", "solaiman", "yasmin", "nusrat", "shohag", "emran" };

            return students[0];


        }



    }



    class OurClass
    {
        string condition = "we are not serious in our studies";
    }




}
