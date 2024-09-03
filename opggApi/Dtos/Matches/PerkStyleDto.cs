using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opggApi.Dtos.Matches
{
    public class PerkStyleDto
    {
        public string Description { get; set; } = string.Empty;
        public List<PerkStylSelectionDto> Selections { get; set; } =
            new List<PerkStylSelectionDto>();
        public int Style { get; set; }
    }
}
