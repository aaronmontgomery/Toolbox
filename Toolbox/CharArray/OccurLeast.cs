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
        public static char[] OccurLeast(this string s)
        {
            return s == string.Empty ?
                throw new ArgumentException("Toolbox.ByteArray.OccurLeast: parameter cannot be empty, string s") :
                s.Distinct().GroupBy(x => s.Count(y => y == x)).OrderBy(x => x.Key).First().ToArray();
        }
    }
}
