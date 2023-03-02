using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetthodsPractice
{
public class Program
    {


        // define a function: MyFullName()
        // 2 parameters: string firstName - "sleepy", string lastName - "joe"
        // return: fullName - "sleepy joe"



        static void LoopTillThisNumber(int num)  // 5
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            }


        


        static int GetMyNameLength(string name)
        {
            return name.Length;    // "Farhad"    -  6 characters (length)
        }



        static string MyGetUpper(string a)
        {
            return a.ToUpper();
        }


        // define a function that takes upper case name ("NYC") and returns lower case name ("nyc")




        // PrintMyName
        static void PrintMyName()
        {
            Console.WriteLine("Sujon");
        }


//       function name: Greeting()
//       static void  - no return
//       purpose: will print: "salam" or "good morning"


        // adding 2 int  - function design / define
        static int AddTwoNumber()
        {
            return 10;
        }

         
        // our function:                      now please define a function that multiplies 3 numbers (a, b, c)                                                
        static int AddThreeNumbers(int x, int y, int z)
        {
            return x + y + z;
        }



        // 3 square   = 3 *3  (multiply by itself

        static double GetSquared(double input)
        {


            double sq  = input * input;

            Console.WriteLine(sq.GetType());

            return sq;

        }


        static void Main()
        {

            Console.WriteLine(GetSquared(9.0));

            Console.WriteLine(GetMyNameLength("Bangladesh                                                   "));


        Console.WriteLine(AddThreeNumbers(1422, 15674, 78));

            PrintMyName();


        // calling the function inside the Main()
        Console.WriteLine(AddTwoNumber());
       






            // I want to print "Good Morning"
            Console.WriteLine();


            Console.WriteLine(12 + 24);

            List<int> list = new List<int>() { 12, 34, 54, 65,34, 132};

            // count
            list.Add(10);
            list.Clear();
            list.Contains(10);


            string name = "florida";
            name.EndsWith("da");
            name.Trim();
            Console.WriteLine(MyGetUpper("DRACULA"));


            LoopTillThisNumber(02);

            


        }




    }
}
