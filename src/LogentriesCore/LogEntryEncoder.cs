using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogentriesCore
{
    internal class LogEntryEncoder : ILogEntryEncoder
    {
        public LogEntryEncoder(Encoding encoding)
        {
            Debug.Assert(encoding != null, $"{nameof(encoding)} != null");

            this.Encoding = encoding;
        }

        public Encoding Encoding { get; }

        public byte[] EncodeEntry(ILogEntry entry)
        {
            return this.Encoding.GetBytes(entry.Line);
        }
    }
}
