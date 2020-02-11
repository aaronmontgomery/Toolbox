using System.Linq;
using System.Collections.Generic;
using System;

namespace Toolbox.Collection
{
    public static partial class Generic
    {
        public static T Least<T>(this IEnumerable<T> collection)
        {
            double d;
            string s = collection.FirstOrDefault().ToString();
            double.TryParse(s, out d);
            foreach (var i in collection.Skip(1))
            {
                double d2;
                string s2 = i.ToString();
                double.TryParse(s2, out d2);
                d = d < d2 ? d : d2;
            }

            return (T)Convert.ChangeType(d, typeof(T));
        }
    }
}
