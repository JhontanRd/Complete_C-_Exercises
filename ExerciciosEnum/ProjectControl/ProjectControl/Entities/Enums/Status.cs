using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectControl.Entities.Enums
{
    internal enum Status : int
    {
        Stopped = 0,
        ScopeDefinition = 1,
        Planning = 2,
        Development = 3,
        Testing = 4,
        Completed = 5
    }
}
