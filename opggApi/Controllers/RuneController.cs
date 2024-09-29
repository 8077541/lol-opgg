using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opggApi.Interfaces;

namespace opggApi.Controllers
{
    [Route("api/runes")]
    [ApiController]
    public class RuneController : ControllerBase
    {
        private readonly IRuneInterface _runeRepository;

        public RuneController(IRuneInterface runeRepository)
        {
            _runeRepository = runeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetRunes()
        {
            var runes = await _runeRepository.GetRunes();
            return Ok(runes);
        }
    }
}
