using System;
using System.Linq;

namespace Toolbox
{
    public static partial class CharArray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static char[] OccurMost(this string s)
        {
            return s == string.Empty ?
                throw new ArgumentException("Toolbox.ByteArray.OccurMost: parameter cannot be empty, string s") :
                s.Distinct().GroupBy(x => s.Count(y => y == x)).OrderByDescending(x => x.Key).First().ToArray();
        }
    }
}
