using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogentriesCore
{
    internal interface ILogEntryEncoder
    {
        byte[] EncodeEntry(ILogEntry entry);
    }
}
