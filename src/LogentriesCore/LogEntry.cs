using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LogentriesCore
{
    internal sealed class LogEntry : ILogEntry
    {
        public LogEntry(string line)
        {
            Debug.Assert(line != null, $"{nameof(line) != null}");

            this.Line = line;
        }

        public string Line { get; }

        public override string ToString()
        {
            return this.Line;
        }
    }
}
