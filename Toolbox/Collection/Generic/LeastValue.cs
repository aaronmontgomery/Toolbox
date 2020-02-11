using System.Linq;
using System.Collections.Generic;
using System;

namespace Toolbox.Collection
{
    public static partial class Generic
    {
        /// <summary>
        /// 
        /// </summary>
        public static int LeastValue<T>(this IEnumerable<T> collection)
        {
            int x = Convert.ToInt32(collection.FirstOrDefault());
            foreach (object i in collection.Skip(1))
            {
                int integer = Convert.ToInt32(i);
                x = integer < x ? integer : x;
            }

            return x;
        }
    }
}
