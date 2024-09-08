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
            var dbProfile = await _profileRepository.GetProfileFromDb(gameName, tagLine);
            if (dbProfile != null)
            {
                return Ok(dbProfile);
            }
            else
            {
                var profile = await _profileRepository.GetPuuid(gameName, tagLine);

                if (profile == null)
                {
                    return NotFound();
                }
                var summoner = await _profileRepository.GetSummoner(profile);
                if (summoner == null)
                {
                    return NotFound();
                }
                var rankeds = await _profileRepository.GetRankeds(summoner);
                if (rankeds == null)
                {
                    return NotFound();
                }

                var profileDto = ProfileMapper.DtoToProfile(profile, summoner);
                ProfileMapper.LeagueEntryToProfile(profileDto, rankeds);
                await _profileRepository.AddProfileToDb(profileDto);
                return Ok(profileDto);
            }
        }
    }
}
