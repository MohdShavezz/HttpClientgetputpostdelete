using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Delete
    {
        public static void _Delete()
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri("https://jsonplaceholder.typicode.com/users/11");


                var getRes = client.GetAsync(endpoint).Result;

                if (getRes.IsSuccessStatusCode)
                {

                    var res = client.DeleteAsync(endpoint).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        Console.WriteLine("deletion successfull..");
                    }
                    else
                    {
                        Console.WriteLine("error...");
                    }
                }
                else
                {
                    Console.Write("Post doesnot exist");
                }
            }
        }
    }
}
