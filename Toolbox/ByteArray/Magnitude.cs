using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Converts byte array to scalar
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="bits"></param>
        /// <returns></returns>
        public static double Magnitude(this byte[] byteArray, int bits)
        {
            switch (byteArray)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Magnitude: parameter cannot be null, byte[] byteArray");
                case byte[] b when byteArray.Length == 0:
                    throw new ArgumentException("Toolbox.ByteArray.Magnitude: parameter cannot be empty, byte[] byteArray");
            }

            if (bits <= 0)
            {
                throw new ArgumentException("Toolbox.ByteArray.Magnitude: parameter must be greater than 0, int bits");
            }

            double magnitude = 0;
            for (int i = 0; i < byteArray.Length; i++)
            {
                magnitude += byteArray[i] * Math.Pow(bits, byteArray.Length - i - 1);
            }

            return magnitude;
        }
    }
}
