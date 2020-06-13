using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class Program
    {
        // private static readonly HttpClient HttpClient = new HttpClient();

        private static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }

        private static bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecciona una de las siguientes opciones:");
            Console.WriteLine("\t1-Mostrar civilizaciones");
            Console.WriteLine("\t2-Mostrar una civilizacion");
            Console.WriteLine("\t3-Mostrar unidades");
            Console.WriteLine("\t4-Mostrar una unidad");
            Console.WriteLine("\t5-Mostrar estructuras");
            Console.WriteLine("\t6-Mostrar una estructura");
            Console.WriteLine("\t7-Mostrar tecnologias");
            Console.WriteLine("\t8-Mostrar una tecnologia");
            Console.WriteLine("\t0-Salir");

            switch (Console.ReadLine())
            {
                case "1":
                    return true;
                case "2":
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        // private static async Task Main(string[] args)
        // {
        //     System.ConsoleApp.WriteLine("Hello World!");
        //
        //     HttpResponseMessage result = await HttpClient.GetAsync("https://age-of-empires-2-api.herokuapp.com/api/v1/unit/1");
        //     var json = result.Content.ReadAsStringAsync().Result;
        //
        //     // var serializeOptions = new JsonSerializerOptions
        //     // {
        //     //     PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy()
        //     // };
        //     //
        //     // var unit = JsonSerializer.Deserialize<Unit>(json, serializeOptions);
        //
        //     DefaultContractResolver contractResolver = new DefaultContractResolver
        //     {
        //         NamingStrategy = new SnakeCaseNamingStrategy()
        //     };
        //
        //     var unit = JsonConvert.DeserializeObject<Unit>(json, new JsonSerializerSettings
        //     {
        //         ContractResolver = contractResolver
        //     });
        //     System.ConsoleApp.WriteLine(result.Content.ReadAsStringAsync().Result);
        //
        // }
    }
}