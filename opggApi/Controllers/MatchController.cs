using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Interfaces;

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
            var match = await _matchRepository.GetMatch(matchId);
            if (match == null)
            {
                return NotFound();
            }
            return Ok(match);
        }
    }
}
