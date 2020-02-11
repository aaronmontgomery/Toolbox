using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// 
        /// </summary>
        public static double Magnitude(this byte[] b, int bits)
        {
            double m = 0;
            for (int i = 0; i < b.Length; i++)
            {
                m += b[i] * Math.Pow(bits, b.Length - i - 1);
            }

            return m;
        }
    }
}