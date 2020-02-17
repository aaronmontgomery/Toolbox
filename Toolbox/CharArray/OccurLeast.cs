using System.Linq;
using System.Collections.Generic;

namespace Toolbox
{
    public static partial class CharArray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static char[] OccurLeast(this string s)
        {
            if (s != string.Empty)
            {
                IEnumerable<IGrouping<int, char>> group = s.Distinct().GroupBy(c => s.Count(o => o == c));
                IOrderedEnumerable<IGrouping<int, char>> order = group.OrderBy(k => k.Key);
                return order.First().ToArray();
            }

            else
            {
                throw new System.ArgumentException("Toolbox.ByteArray.OccurLeast: parameter cannot be empty, string s");
            }
        }
    }
}
