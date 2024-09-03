using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggApi.Dtos.Matches
{
    public class PerksDto
    {
        public PerkStatsDto StatPerks { get; set; }
        public List<PerkStylDto> Styles { get; set; }
    }
}
