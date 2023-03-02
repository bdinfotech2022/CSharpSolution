using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp;


namespace APITestDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // url, client, request (parameterized), response
            var url = "https://jsonplaceholder.typicode.com/posts";
            RestClient client = new RestClient();

            RestRequest request = new RestRequest(url);

            var response = client.Get(request);

            Console.WriteLine(response.Content.ToString());   // complete response

            // status / response code:
            Console.WriteLine(response.StatusCode);   // OK

            Console.WriteLine((int) response.StatusCode);
        }
    }
}
