using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Teste.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/users/takenet/repos");
            client.DefaultRequestHeaders.Add("User-Agent", "request");
            var response = client.Send(request);
            var stringResponse  = response.Content.ReadAsStringAsync();
            var repos = JsonConvert.DeserializeObject<List<Repos>>(stringResponse.Result.ToString());
        }
    }
}
