using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opggApi.Data;
using opggApi.Dtos.Runes;
using opggApi.Interfaces;

namespace opggApi.Repositories
{
    public class RuneRepository(HttpClient httpClient, ApplicationDbContext context)
        : IRuneInterface
    {
        private readonly ApplicationDbContext _context = context;
        private readonly HttpClient _httpClient = httpClient;

        public async Task<List<Rune>> GetRunes()
        {
            var response = await _httpClient.GetAsync(
                "https://ddragon.leagueoflegends.com/cdn/14.19.1/data/en_US/runesReforged.json"
            );
            var runesDto = await response.Content.ReadFromJsonAsync<List<TreeDto>>();
            throw new NotImplementedException();
        }
    }
}
