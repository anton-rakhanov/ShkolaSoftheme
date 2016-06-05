using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFiles.Data
{
    [Flags]
    public enum FileAccessEnum
    {
        None = 0,
        Read = 1,
        Write = 2,
    }
}
