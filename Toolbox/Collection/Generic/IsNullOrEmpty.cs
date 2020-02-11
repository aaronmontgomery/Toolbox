using System.Linq;
using System.Collections.Generic;

namespace Toolbox.Collection
{
    public static partial class Generic
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return (collection == null || !collection.Any()) ? true : false;
        }
    }
}
