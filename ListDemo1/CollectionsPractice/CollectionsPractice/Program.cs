using System;
using System.Collections.Generic;  // <- for non-generic collection
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{   
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> food1 = new HashSet<string>() { "cake", "pizza", "pasta", "rice", "bread", "cheese"};
            
            HashSet<string> food2 = new HashSet<string>() { "cheese", "panini", "mosambi", "rice", "noodle" };

            //   food1.IntersectWith(food2);  // returns the common item(s) from the first HS

            food1.UnionWith(food2);         // returns all the items combined in the first HS

            Console.WriteLine(string.Join(" ", food1));


            HashSet<int> set = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 8, 9, 10 };
            set.UnionWith(set2);
            Console.WriteLine(string.Join(" ", set));



            HashSet<string> namesA = new HashSet<string>() { "jeff", "james", "jack" };
            HashSet<string> names = new HashSet<string> { "jack", "james", "john" };

            namesA.ExceptWith(names);  // all common items will be deleted from the first HS
            Console.WriteLine(string.Join(" ", namesA));

        }
    }
}
