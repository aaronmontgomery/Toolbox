using System;
using System.Linq;
using System.Collections.Generic;

namespace Toolbox.Collection
{
    public static partial class Generic
    {
        /// <summary>
        /// 
        /// </summary>
        public static int UniqueId<T>(this IEnumerable<T> collection)
        {
            Random r = new Random();
            int i = r.Next(0, int.MaxValue);
            while (collection.Any(item => item.Equals(i)))
            {
                i = r.Next(0, int.MaxValue);
            }

            return i;
        }
    }
}
