using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogentriesCore
{
    internal interface ILogEntry
    {
        string Line { get; }
    }
}
