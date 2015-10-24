using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LogentriesCore
{
    internal abstract class LogEntryDecorator : ILogEntry
    {
        protected LogEntryDecorator(ILogEntry baseEntry)
        {
            Debug.Assert(baseEntry != null, $"{nameof(baseEntry)} != null");

            this.BaseEntry = baseEntry;
        }

        public ILogEntry BaseEntry { get; }

        public virtual string Line => this.BaseEntry.Line;
    }
}
