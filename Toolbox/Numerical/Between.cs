namespace Toolbox
{
    public static partial class Numerical
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Between(this int x, int min, int max)
        {
            return min < x && x < max;
        }
    }
}
