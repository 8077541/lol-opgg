using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opggApi.Dtos.Runes;
using opggApi.Models;

namespace opggApi.Mappers
{
    public class RuneMapper
    {
        public static List<RuneModel> DtoToRunes(List<TreeDto> runesDto)
        {
            var runes = new List<RuneModel>();
            foreach (var tree in runesDto)
            {
                foreach (var slot in tree.Slots)
                {
                    foreach (var rune in slot.Runes)
                    {
                        runes.Add(
                            new RuneModel
                            {
                                RuneId = rune.Id,
                                Name = rune.Name,
                                Description = rune.LongDesc,
                                Image = rune.Icon,
                            }
                        );
                    }
                }
            }
            return runes;
        }

        public static Participant AddRunesToParticipant(
            Participant participant,
            List<RuneModel> runes
        )
        {
            foreach (var rune in runes)
            {
                if (participant.Runes == null)
                {
                    participant.Runes = new List<RuneModel>();
                }
                participant.Runes.Add(rune);
            }
            return participant;
        }
    }
}
