using System;

namespace Toolbox
{
    public static partial class Numerical
    {
        /// <summary>
        /// Generates a random integer within a range
        /// </summary>
        /// <param name="x"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static int Random(this int x, int range)
        {
            return new Random().Next(x - range, x + range);
        }
    }
}
