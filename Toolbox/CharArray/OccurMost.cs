using System.Linq;
using System.Collections.Generic;

namespace Toolbox
{
    public static partial class CharArray
    {
        public static char[] OccurMost(this string s)
        {
            if (s != string.Empty)
            {
                IEnumerable<IGrouping<int, char>> group = s.Distinct().GroupBy(c => s.Count(o => o == c));
                IOrderedEnumerable<IGrouping<int, char>> order = group.OrderByDescending(k => k.Key);
                return order.First().ToArray();
            }

            else
            {
                throw new System.ArgumentException("Toolbox.ByteArray.OccurMost: parameter cannot be empty, string s");
            }
        }
    }
}
