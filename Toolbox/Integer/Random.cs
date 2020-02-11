using System;

namespace Toolbox
{
    public static partial class Integer
    {
        public static int Random(this int i, int bounds)
        {
            return new Random().Next(i - bounds, i + bounds);
        }
    }
}
