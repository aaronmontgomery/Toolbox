using System;
using System.Linq;
using System.Reflection;

namespace Toolbox.Collection
{
    public static partial class Generic
    {
        /// <summary>
        /// 
        /// </summary>
        public static PropertyInfo GenericProperty(Type type, string property)
        {
            string[] p = property.Split(new char[] { '.' });
            PropertyInfo r = type.GetProperty(p.FirstOrDefault());
            for (int i = 1; i < p.Length; i++)
            {
                r = r.GetType().GetProperty(p[i]);
            }

            return r;
        }
    }
}
