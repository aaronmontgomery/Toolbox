using System.Linq;
using System.Collections.Generic;

namespace Toolbox.Collection
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class Generic
    {
        public static int IndexOf<T>(this IEnumerable<T> items, object item)
        {
            int i = 0;
            List<int> indexes = new List<int>();
            foreach (object o in items)
            {
                if (o.Equals(item))
                {
                    indexes.Add(i);
                }

                i++;
            }

            return indexes.Single();
        }
    }
}
