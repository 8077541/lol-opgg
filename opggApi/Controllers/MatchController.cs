using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Interfaces;
using opggApi.Mappers;

namespace opggApi.Controllers
{
    [Route("api/match")]
    [ApiController]
    public class MatchController(IMatchInterface matchRepository) : ControllerBase
    {
        private readonly IMatchInterface _matchRepository = matchRepository;

        [HttpGet]
        public async Task<IActionResult> GetMatchIds([FromQuery] string puuid)
        {
            var matchIds = await _matchRepository.GetMatchIds(puuid);
            if (matchIds == null)
            {
                return NotFound();
            }
            return Ok(matchIds);
        }

        [HttpGet("matchDetails")]
        public async Task<IActionResult> GetMatchDetails([FromQuery] string matchId)
        {
            var matchDb = await _matchRepository.GetMatchFromDb(matchId);
            if (matchDb != null)
            {
                return Ok(matchDb);
            }
            else
            {
                var match = await _matchRepository.GetMatch(matchId);
                if (match == null)
                {
                    return NotFound();
                }
                var matchModel = MatchMapper.MatchDtoToMatch(match);
                await _matchRepository.AddMatchToDb(matchModel);
                return Ok(matchModel);
            }
        }
    }
}
