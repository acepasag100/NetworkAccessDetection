using NetworkAccessDetection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace NetworkAccessDetection.Service
{
    public class RickAndMortyService : IRickAndMortyService
    {
        public string urlAPI = "https://rickandmortyapi.com/api/character";
        public async Task<List<PersonResponse>> Obtainer()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlAPI);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodes = JsonNode.Parse(responseBody);
            JsonNode results = nodes["results"];

            var personData = JsonSerializer.Deserialize<List<PersonResponse>>(results.ToString());
            return personData;
        }
    }
}
