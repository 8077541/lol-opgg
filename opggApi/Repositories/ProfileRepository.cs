using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Dtos;
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
                $"https://europe.api.riotgames.com/riot/account/v1/accounts/by-riot-id/{gameName}/{tagLine}?api_key={riotApi}"
            );
            var accountModel = await response.Content.ReadFromJsonAsync<AccountDto>();

            if (accountModel == null)
            {
                throw new Exception("Account not found");
            }

            return accountModel;
        }

        // PUUID vEJrdiGhWv_bPfFyTzAbHVxp7ouqQms69W9LUxto9Jc1z5grT68FRY0kVw8ppcnihnlyP5jC5ymvHg
        public async Task<SummonerDto> GetSummoner(AccountDto account)
        {
            var riotApi = _configuration.GetSection("RiotApi").GetSection("ApiKey").Value;
            var response = await _httpClient.GetAsync(
                $"https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-puuid/{account.Puuid}?api_key={riotApi}"
            );
            var summonerModel =
                await response.Content.ReadFromJsonAsync<SummonerDto>()
                ?? throw new Exception("Summoner not found");
            return summonerModel;
        }

        // SUMMONER ID NEoqpMnRIDbGhPCkT6IWNVdGjduskeXRMnS9-72ffDp9nxwh
        public async Task<List<LeagueEntryDto>> GetRankeds(SummonerDto summoner)
        {
            var riotApi = _configuration.GetSection("RiotApi").GetSection("ApiKey").Value;
            var response = await _httpClient.GetAsync(
                $"https://euw1.api.riotgames.com/lol/league/v4/entries/by-summoner/{summoner.Id}?api_key={riotApi}"
            );
            var leagueEntryModel = await response.Content.ReadFromJsonAsync<List<LeagueEntryDto>>();
            if (leagueEntryModel == null)
            {
                throw new Exception("Rankeds not found");
            }
            return leagueEntryModel;
        }
    }
}
