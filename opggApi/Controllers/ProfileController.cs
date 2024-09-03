using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Interfaces;
using opggApi.Repositories;

namespace opggApi.Controllers
{
    [Route("api/profile")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileInterface _profileRepository;

        public ProfileController(IProfileInterface profileRepository)
        {
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

            return Ok(profile);
        }
    }
}
