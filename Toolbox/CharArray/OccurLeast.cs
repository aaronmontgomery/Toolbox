using System.Linq;
using System.Collections.Generic;

namespace Toolbox
{
    public static partial class CharArray
    {
        public static char[] OccurLeast(this string s)
        {
            IEnumerable<IGrouping<int, char>> group = s.Distinct().GroupBy(c => s.Count(o => o == c));
            IOrderedEnumerable<IGrouping<int, char>> order = group.OrderBy(k => k.Key);
            return order.First().ToArray();
        }
    }
}
