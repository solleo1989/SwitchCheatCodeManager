using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCheatCodeManager.Comparator
{
    /**
     * Comparer for the version digist, i.e. 2.0.0 ~ 12.0.0
     * How to determine the version digits, instead of doing a
     * pure string comparison. We need to saparately compare the
     * digits on each version.
     * @param: int x, int y. 2 digits to compare.
     */
    public class TextboxComparator : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var xStr = x.ReplaceLineEndings();
            var yStr = y.ReplaceLineEndings();
            return xStr.CompareTo(yStr);
        }
    }
}
