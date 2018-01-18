using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LemonWay.Console
{
    class Program
    {
        static string baseUrl = "http://localhost:53949";

        static void Main(string[] args)
        {
            string url = String.Format("{0}/api/service/fibonacci?n=10", baseUrl);

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(baseUrl);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string value = client.GetStringAsync(url).Result;

            System.Console.WriteLine(value);

            System.Console.ReadKey();
        }
    }
}
