using System;

namespace Toolbox
{
    public static partial class Numerical
    {
        public static int Random(this int x, int tolerance)
        {
            return new Random().Next(x - tolerance, x + tolerance);
        }
    }
}
