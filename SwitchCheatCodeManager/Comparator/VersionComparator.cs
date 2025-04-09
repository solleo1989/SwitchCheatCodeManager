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
            // Main goal of comparison 2 digits.
            // i.e., 1.0.0 vs 1.0.1
            if (x.Contains(".") && y.Contains("."))
            {
                var xparts = x.Split(".");
                var yparts = y.Split(".");                
                for (var i = 0; i < Math.Min(xparts.Length, yparts.Length); i++)
                {
                    long xdigit, ydigit;
                    bool xConvert = long.TryParse(xparts[i], out xdigit);
                    bool yConvert = long.TryParse(yparts[i], out ydigit);
                    if (xConvert && yConvert)
                    {
                        if (xdigit > ydigit)        // 1.1.0 > 1.0.0 => 2
                        {
                            return i + 1;
                        }
                        else if (xdigit < ydigit)   // 1.0.0 < 1.0.1 => -3
                        {
                            return -i - 1;
                        }
                    }
                    else
                    {
                        // 1.x2341312 will be consider as string compare
                        return string.Compare(x, y, true);
                    }
                }

                if (xparts.Length > yparts.Length)  // 1.0.0.1 > 1.0.0 -> -3
                {
                    return yparts.Length;
                }
                else if (xparts.Length < yparts.Length) // 1.0.2 < 1.0.2.1 -> 3
                {
                    return -xparts.Length;
                }
                else
                {
                    return 0;
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
