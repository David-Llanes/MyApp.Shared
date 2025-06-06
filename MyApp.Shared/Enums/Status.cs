using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tapper;

namespace SmacoDevs.MyShared.Enums
{
    [TranspilationSource]
    public enum Status
    {
        Inactive = 0,
        Active = 1,
        Deleted = 2,
        Testing = 3
    }
}
