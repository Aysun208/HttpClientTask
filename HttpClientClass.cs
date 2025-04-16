using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient
{
    public class HttpClientClass
    {
        public static async Task GetData(List<string> urls)
        {
            HttpClientClass client = new HttpClientClass();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (string url in urls)
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("request send:" + url);
                    }
                    else
                    {
                        Console.WriteLine($"Request failed:{url} . Status code:{response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error request {url} {ex.Message}");
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"umumi vaxt: {stopwatch.Elapsed.TotalSeconds} saniyedir");
        }
        private async Task<HttpResponseMessage> GetAsync(string url)
        {
            throw new NotImplementedException();
        }
    }
}
