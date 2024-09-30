using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opggApi.Data;
using opggApi.Dtos.Runes;
using opggApi.Interfaces;
using opggApi.Mappers;
using opggApi.Models;

namespace opggApi.Repositories
{
    public class RuneRepository(HttpClient httpClient, ApplicationDbContext context)
        : IRuneInterface
    {
        private readonly ApplicationDbContext _context = context;
        private readonly HttpClient _httpClient = httpClient;

        public async Task<List<RuneModel>> GetRunes()
        {
            var response = await _httpClient.GetAsync(
                "https://ddragon.leagueoflegends.com/cdn/14.19.1/data/en_US/runesReforged.json"
            );
            var runesDto = await response.Content.ReadFromJsonAsync<List<TreeDto>>();
            if (runesDto != null)
            {
                var runes = RuneMapper.DtoToRunes(runesDto);
                return runes;
            }
            throw new Exception("Error");
        }

        public async Task<RuneModel?> GetRune(int id)
        {
            var rune = await _context.Runes.FindAsync(id);
            if (rune == null)
            {
                return null;
            }
            return rune;
        }

        public async Task<List<RuneModel>> AddRunesToDb(List<RuneModel> runes)
        {
            foreach (var rune in runes)
            {
                var check = await _context.Runes.FindAsync(rune.Id);
                if (check != null)
                {
                    throw new Exception("Rune already exists");
                }
                _context.Runes.Add(rune);
            }
            await _context.SaveChangesAsync();
            return runes;
        }
    }
}
