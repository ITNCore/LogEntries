using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encoding = System.Text.Encoding;

namespace LogentriesCore
{
    internal sealed class ASCIILogEntryEncoder : LogEntryEncoder
    {
        public ASCIILogEntryEncoder()
            : base(Encoding.ASCII)
        { }
    }
}
