using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opggApi.Interfaces
{
    public interface IRuneInterface
    {
        Task<List<Rune>> GetRunes();
    }
}
