using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AgeOfEmpiresIIData
{
    static class Program
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HttpResponseMessage result = await HttpClient.GetAsync("https://age-of-empires-2-api.herokuapp.com/api/v1/civilizations");
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);


            // HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://age-of-empires-2-api.herokuapp.com/api/v1/civilizations");
            // request.Method = "POST";
            // request.ContentType = "application/x-www-form-urlencoded";
        }
    }
}