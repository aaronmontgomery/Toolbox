using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// 
        /// </summary>
        public static byte[] Vector(this double m, int bits)
        {
            if (m.Equals(0)) { return new byte[] { 0 }; }
            byte[] r = new byte[(int)Math.Ceiling(Math.Log(m, bits))];
            for (int i = 0; i < r.Length; i++)
            {
                double f = Math.Pow(bits, r.Length - i - 1);
                r[i] = (byte)(m / f);
                m -= r[i] * f;
            }

            return r;
        }
    }
}