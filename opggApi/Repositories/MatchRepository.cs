using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using opggApi.Data;
using opggApi.Dtos.Matches;
using opggApi.Interfaces;
using opggApi.Models;

namespace opggApi.Repositories
{
    public class MatchRepository(
        IConfiguration configuration,
        HttpClient httpClient,
        ApplicationDbContext context
    ) : IMatchInterface
    {
        private readonly ApplicationDbContext _context = context;
        private readonly HttpClient _httpClient = httpClient;
        private readonly IConfiguration _configuration = configuration;

        public async Task<MatchLoL> AddMatchToDb(MatchLoL match)
        {
            await _context.Matches.AddAsync(match);
            await _context.SaveChangesAsync();
            return match;
        }

        public async Task<MatchLoL> GetMatchFromDb(string match)
        {
            return await _context
                .Matches.Include(p => p.Participants)
                .Where(m => m.MatchId == match)
                .FirstOrDefaultAsync();
        }

        public async Task<MatchDto> GetMatch(string matchId)
        {
            var riotApi = _configuration.GetSection("RiotApi").GetSection("ApiKey").Value;
            var response = await _httpClient.GetAsync(
                $"https://europe.api.riotgames.com/lol/match/v5/matches/{matchId}?api_key={riotApi}"
            );
            var match = await response.Content.ReadFromJsonAsync<MatchDto>();
            if (match == null)
            {
                throw new Exception("Match not found");
            }
            return match;
        }

        public async Task<List<string>> GetMatchIds(string puuid)
        {
            var riotApi = _configuration.GetSection("RiotApi").GetSection("ApiKey").Value;
            var response = await _httpClient.GetAsync(
                $"https://europe.api.riotgames.com/lol/match/v5/matches/by-puuid/{puuid}/ids?start=0&count=20&api_key={riotApi}"
            );
            var matchIds = await response.Content.ReadFromJsonAsync<List<string>>();
            if (matchIds == null)
            {
                throw new Exception("MatchIds not found");
            }
            return matchIds;
        }
    }
}
