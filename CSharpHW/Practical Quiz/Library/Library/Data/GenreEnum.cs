using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    [Flags]
    public enum GenreEnum
    {
        ScienceFiction = 0x0,
        Fantasy = 0x1,
        Drama = 0x2,
        Adventure = 0x4,
        Triller = 0x8,
        Horror = 0x10
    }
}
