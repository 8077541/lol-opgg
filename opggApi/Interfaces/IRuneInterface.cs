using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opggApi.Models;

namespace opggApi.Interfaces
{
    public interface IRuneInterface
    {
        Task<List<RuneModel>> GetRunes();
        Task<RuneModel> GetRune(int id);

        Task<List<RuneModel>> AddRunesToDb(List<RuneModel> runes);
    }
}
