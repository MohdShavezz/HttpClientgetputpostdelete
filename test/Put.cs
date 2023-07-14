using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Put
    {
        public static void _Put()
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/users/2");

                if (client.GetAsync(endpoint).Result.IsSuccessStatusCode)
                {
                    var item = new Post()
                    {
                        userid = 4,
                        title = "title Change",
                        body = "Body Change"

                    };
                    var itemJson = JsonConvert.SerializeObject(item);
                    var payload = new StringContent(itemJson, Encoding.UTF8, "application/json");
                    var res = client.PutAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
                    Post x = JsonConvert.DeserializeObject<Post>(res);

                    Console.WriteLine($"{x.userid}\n{x.title}\n{x.body}  ");
                }
                else
                {
                    Console.WriteLine("doest exist.");
                }

                Console.ReadLine();
            }

        }
    }
}
