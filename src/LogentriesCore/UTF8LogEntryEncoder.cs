using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encoding = System.Text.Encoding;

namespace LogentriesCore
{
    internal sealed class UTF8LogEntryEncoder : LogEntryEncoder
    {
        public UTF8LogEntryEncoder()
            : base(Encoding.UTF8)
        { }
    }
}