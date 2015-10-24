using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogentriesCore
{
    internal class PrefixDecorator : LogEntryDecorator
    {
        public PrefixDecorator(ILogEntry baseEntry, string prefix)
            : base(baseEntry)
        {
            this.Prefix = prefix;
        }

        public string Prefix { get; }

        public override string Line => this.Prefix + base.Line;
    }
}
