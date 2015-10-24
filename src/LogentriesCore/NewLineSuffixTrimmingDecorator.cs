using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogentriesCore
{
    /// <summary>
    /// Removes new line characters from the end of an ILogEntry.
    /// </summary>
    internal sealed class NewLineSuffixTrimmingDecorator : LogEntryDecorator
    {
        private static readonly char[] newLineChars = new char[] { '\r', '\n' };

        public NewLineSuffixTrimmingDecorator(ILogEntry baseEntry)
            : base(baseEntry)
        { }

        public override string Line => base.Line.TrimEnd(newLineChars);
    }
}
