using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractice2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // string: is a class
            // name: string variable or string object thar represents the entire string
            // = assignment operator
            //  "james" is the string value / literal
            // ; marks the end of this statement
            string name = "james";



            // String function: EndsWith()


            // returns: bool True or False
            string city = "new york city";
            bool output = city.EndsWith("city");    //  EndsWith()
            Console.WriteLine(output);


            int num1 = 12;
            int num2 = 24;
            int result = num1 + num2;
            Console.WriteLine(result);


            string n1 = "donald ", n2 = "trump";
            Console.WriteLine(  string.Concat(n1, n2)            );  // method signature = method name + list of parameters


            // function / method name: Compare()
            // purpose: compares first string with second string
            // parameters: string1 and string2
            // returns: int     : 0 if 2 strings are same,   1 when s1 > s2,   -1 when s1 < s2


            string fruit1 = "cherry";  // lexicographical (dictionary) order
            string fruit2 = "berry";                        
            Console.WriteLine( string.Compare(fruit1, fruit2) );


            // function name: ToCharArray()
            // purpose: converts a string to an array of characters
            // parameter(s): 0
            // return: array of char


            string flower = "lotus";
            char [] letters = flower.ToCharArray();           // 'l', 'o', 't', 'u', 's'
            Console.WriteLine(string.Join(", ", letters));


            string schoolSupply = "backpack";
            Console.WriteLine(schoolSupply.Substring(4));

            string id = "cis0012";

            Console.WriteLine(id.Substring(0, 5)); // starts at 0 index, 5 characters


            string fullname = "MD ASAD CHOWDHURY";

            Console.WriteLine(fullname.Substring(3, 4));   // index starts at 0, Length starts at 1




            List<char> mycharlist = new List<char>() { 'q', 'b', 'j', 'q', 'b', 'j' , 'q', 'b', 'j' , 'q', 'b', 'j' }; // element = item

            mycharlist.Add('z');

            Console.WriteLine(string.Join(" ", mycharlist));
            Console.WriteLine(mycharlist.Count);

            // list name: wellnessitems
            // cabbage, spinach, whey, carrot, squash


            // apple cider vinegar

            // print all the element





            // Full name: MD EMRAN HASAN
            // YASMIN AKTER SUMI
            // SHOHAG


            List<string> fruits = new List<string>();
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("dragonfruit");
            fruits.Add("jackfruit");

            Console.WriteLine(string.Join(", ", fruits));

            fruits.Sort();
            Console.WriteLine(string.Join(", "    ,    fruits));

            fruits.Reverse();
            Console.WriteLine(string.Join(", ", fruits));


            // an empty list of int:
            List<int> numberList = new List<int>() { 10, 34, 76, 34, 8, 45, 34, 78, 34, 23, 89, 100};

            numberList.Add(13);   // Add() can add JUST ONE item at a time 
            numberList.Add(15);
            numberList.Add(16);

            Console.WriteLine(string.Join(", ", numberList));  // for any type of data: we must use string

            numberList.Sort();          // ASCending order
            numberList.Reverse();       // DESCending order

            Console.WriteLine(numberList.Sum());
            Console.WriteLine(numberList.Max());
            Console.WriteLine(numberList.Min());
            Console.WriteLine(numberList.Average());



        }
    }
}
