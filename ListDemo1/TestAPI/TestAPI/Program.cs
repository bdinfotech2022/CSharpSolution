using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace TestAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string url = "https://jsonplaceholder.typicode.com/posts";
            var client = new RestClient();
            var request = new RestRequest(url);

            var body = new post {body = "our test body",
            title = "test title",
            userId = 100};

            request.AddJsonBody(body);

            var response = client.Post(request);

            Console.WriteLine(response.Content.ToString());   // the content
            Console.WriteLine(response.StatusCode.ToString());   // OK
            Console.WriteLine(((int)response.StatusCode));
            Console.Read();


            /* GET request:
                    string url = "https://jsonplaceholder.typicode.com/posts";
                    var client = new RestClient();
                    var request = new RestRequest(url);
                    request.AddParameter("id", "3");
                    var response = client.Get(request);
                    Console.WriteLine(response.Content.ToString());   // the content
                    Console.WriteLine(response.StatusCode.ToString());   // OK
                    Console.WriteLine(((int)response.StatusCode));
                    Console.Read();
            */
        }
    }
}
