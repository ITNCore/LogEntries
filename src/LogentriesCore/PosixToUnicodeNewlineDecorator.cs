using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogentriesCore
{
    internal sealed class PosixToUnicodeNewlineDecorator : LogEntryDecorator
    {
        private const string unicodeNewline = "\u2028";

        private static readonly string[] posixNewlineStrings = new string[] { "\r\n", "\n" };
        
        public PosixToUnicodeNewlineDecorator(ILogEntry baseEntry)
            : base(baseEntry)
        { }

        public override string Line
        {
            get
            {
                string line = base.Line;
                foreach (string newline in posixNewlineStrings)
                {
                    line = line.Replace(newline, unicodeNewline);
                }
                return line;
            }
        }
    }
}
