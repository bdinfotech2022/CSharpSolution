using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
namespace MyAPITest
{
    public class Class1
    {

        public static void Main(String[] args)
        {

            string baseURL = "https://jsonplaceholder.typicode.com/todos/1";

            var client = new RestClient(baseURL);

            var requst = new RestRequest();

            var response = client.Get(requst);

            Console.WriteLine(response.Content.ToString());


        }
    }
}