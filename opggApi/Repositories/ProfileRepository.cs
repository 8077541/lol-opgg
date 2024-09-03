using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Interfaces;
using opggApi.Models;

namespace opggApi.Repositories
{
    public class ProfileRepository(IConfiguration configuration, HttpClient httpClient)
        : IProfileInterface
    {
        private readonly HttpClient _httpClient = httpClient;
        private readonly IConfiguration _configuration = configuration;

        public async Task<AccountDto> GetPuuid(string gameName, string tagLine)
        {
            var riotApi = _configuration.GetSection("RiotApi").GetSection("ApiKey").Value;
            var response = await _httpClient.GetAsync(
                $"https://americas.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{gameName}/{tagLine}?api_key={riotApi}"
            );
            var accountModel = await response.Content.ReadFromJsonAsync<AccountDto>();

            if (accountModel == null)
            {
                throw new Exception("Account not found");
            }

            return accountModel;
        }
    }
}
