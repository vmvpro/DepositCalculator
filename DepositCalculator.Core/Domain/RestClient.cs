using DepositCalculator.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DepositCalculator.Core.Domain
{
    public class RestClient
    {
        public static readonly string HostUrl = "http://localhost:5130/api/deposit";

        public static async Task PostAsync<T>(T body, string routeApi)
        {
            var url = String.Concat(HostUrl, routeApi);

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize<T>(body, serializeOptions);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            await client.PostAsync(url, data);

        }

        public static async Task<Response<Tout>> PostAsyncToObject<Tout, Tin>(Tin body, string routeApi)
        {
            var url = String.Concat(HostUrl, routeApi);

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize<Tin>(body, serializeOptions);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            if (!response.IsSuccessStatusCode)
                throw new Exception(response.ToString());

            using var reponseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Response<Tout>>(reponseStream, serializeOptions);

        }

        public static async Task<T> GetStreamAsync<T>(string routeApi)
        {
            using var client = new HttpClient();

            var streamTask = await client.GetStreamAsync(String.Concat(HostUrl, routeApi));

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            return await JsonSerializer.DeserializeAsync<T>(streamTask, serializeOptions);

        }



    }
}
