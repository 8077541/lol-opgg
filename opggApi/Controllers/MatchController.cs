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
    public class MatchController(IMatchInterface matchRepository, IRuneInterface runeRepository)
        : ControllerBase
    {
        private readonly IRuneInterface _runeRepository = runeRepository;
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
                foreach (var participant in matchModel.Participants)
                {
                    participant.Runes = await _runeRepository.AddRunesToParticipant(participant);
                }
                await _matchRepository.AddMatchToDb(matchModel);
                return Ok(matchModel);
            }
        }
    }
}
