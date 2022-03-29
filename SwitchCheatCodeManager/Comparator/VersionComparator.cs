using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCheatCodeManager.Comparator
{
    /**
     * Comparer for version digits, i.e. 2.0.0 ~ 12.0.0
     * How to determine the version digits, instead of doing a
     * pure string comparison. We need to saparately compare the
     * digits on each version.
     * @param: int x, int y. 2 digits to compare.
     */
    public class VersionComparator : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            // Main gold of comparison 2 digits.
            if (x.Contains(".") && y.Contains("."))
            {
                var xparts = x.Split(".");
                var yparts = y.Split(".");
                // Note: Here we only compare the same version format
                if (xparts.Length == yparts.Length)
                {
                    for (var i = 0; i < xparts.Length; i++)
                    {
                        long xdigit, ydigit;
                        bool xConvert = long.TryParse(xparts[i], out xdigit);
                        bool yConvert = long.TryParse(yparts[i], out ydigit);
                        if (xConvert && yConvert)
                        {
                            if (xdigit > ydigit)
                            {
                                return i+1;
                            }
                            else if (xdigit < ydigit)
                            {
                                return -i-1;
                            }
                        }
                        else 
                        {
                            return string.Compare(x, y, true);
                        }
                    }
                    return 0;
                }
                else
                {
                    return string.Compare(x, y, true);
                }
            }
            else
            {
                // If the comparison format are whole digits, we did a straight compare
                return string.Compare(x, y, true);
            }
        }
    }
}
