﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using AgeOfEmpiresIIData.Domain;
using AgeOfEmpiresIIData.Domain.Unit;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AgeOfEmpiresIIData
{
    static class Program
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HttpResponseMessage result = await HttpClient.GetAsync("https://age-of-empires-2-api.herokuapp.com/api/v1/unit/1");
            var json = result.Content.ReadAsStringAsync().Result;

            // var serializeOptions = new JsonSerializerOptions
            // {
            //     PropertyNamingPolicy = new JsonSnakeCaseNamingPolicy()
            // };
            //
            // var unit = JsonSerializer.Deserialize<Unit>(json, serializeOptions);

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            var unit = JsonConvert.DeserializeObject<Unit>(json, new JsonSerializerSettings
            {
                ContractResolver = contractResolver
            });
            Console.WriteLine(result.Content.ReadAsStringAsync().Result);

        }
    }
}