using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // can we convert a list to an array?   --   ToArray()
            List<string> foodList = new List<string>() {"cheesecake", "pan cake", "fruit cake" };
            string[] foodArray = foodList.ToArray();
            Console.WriteLine(foodArray.GetType());



            // can we convert an array to a list? -- ToList()
            string[] fishArray = { "salmon", "tuna", "bass", "hilsa" };


            List<string> fishList = fishArray.ToList();
            Console.WriteLine(fishList.GetType());


        }
    }
}
