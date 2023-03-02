using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        //  a field with a private AM can only be accessed within the same class
        //  trying to access it outside the class, an error will occur    
        
        public static string color = "green";
        
    }

    public class Test
    {
        static void Main(string[] args)
        {

            Program pg = new Program();

        Console.WriteLine(Program.color);
        }
    }
}