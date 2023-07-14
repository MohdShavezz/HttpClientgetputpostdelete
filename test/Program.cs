using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/users/");

                //GET
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                Console.WriteLine(json);

                //POST
                //var item = new Post()
                //{
                //    title = "this is title",
                //    body = "this is body",
                //    userid = 11
                //};

                //var itemjson = JsonConvert.SerializeObject(item);
                //var payload = new StringContent(itemjson, Encoding.UTF8, "application/json");
                //var res = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
                //Console.WriteLine(res);

                //Put._Put();
                //Delete._Delete();
                Console.ReadLine();
            }
            
        }
    }
}
