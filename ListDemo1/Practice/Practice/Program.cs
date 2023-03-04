using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {

        // access modifiers: public static
        // a method name: GetLen(){ } 
        // input parameter: string
        // output / return type: length (how many characters) - int

        public static int GetLen(string text) {

            // logic / algorithm

            int len = text.Length;


            return len;

        }


        static void Main(string[] args)
        {

            // calling the method inside the Main():  actual name of our method + actual value
            Console.WriteLine(GetLen("atikur rahman"));


        }
    }
}















