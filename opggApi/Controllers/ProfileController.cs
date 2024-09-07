using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Interfaces;
using opggApi.Mappers;
using opggApi.Repositories;

namespace opggApi.Controllers
{
    [Route("api/profile")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileInterface _profileRepository;
        private readonly IMatchInterface _matchRepository;

        public ProfileController(
            IProfileInterface profileRepository,
            IMatchInterface matchRepository
        )
        {
            _matchRepository = matchRepository;
            _profileRepository = profileRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPuuid(
            [FromQuery] string gameName,
            [FromQuery] string tagLine
        )
        {
            var profile = await _profileRepository.GetPuuid(gameName, tagLine);

            if (profile == null)
            {
                return NotFound();
            }
            var summoner = await _profileRepository.GetSummoner(profile);
            var rankeds = await _profileRepository.GetRankeds(summoner);

            var profileDto = ProfileMapper.DtoToProfile(profile, summoner);
            ProfileMapper.LeagueEntryToProfile(profileDto, rankeds);
            return Ok(profileDto);
        }
    }
}
