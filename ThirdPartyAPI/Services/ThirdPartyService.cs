using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ThirdPartyAPI.Poco;

namespace ThirdPartyAPI.Services
{
    public class ThirdPartyService : IThirdPartyService
    {
        private readonly HttpClient _Client;
        public ThirdPartyService(
            IConfiguration configuration,
            HttpClient client)
        {
            var url = new Uri( configuration["Microservice:Begonia"]);
            client.BaseAddress = url;
            _Client = client;
        }
        public async Task<string> GotoGameAsync(TpInfo tpInfo)
        {
            string json = JsonSerializer.Serialize(tpInfo);
            StringContent stringContent = new StringContent(json);
            var resp =  await _Client.PostAsync("ThirdParty", stringContent);
            resp.EnsureSuccessStatusCode();
            var result = await resp.Content.ReadAsStringAsync();
            return result;
        }
    }
}
