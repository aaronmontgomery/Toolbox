using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="magnitude"></param>
        /// <param name="bits"></param>
        /// <returns></returns>
        public static byte[] Vector(this double magnitude, int bits)
        {
            if (bits > 0)
            {
                if (magnitude > 0)
                {
                    byte[] result = new byte[(int)Math.Ceiling(Math.Log(magnitude, bits))];
                    for (int i = 0; i < result.Length; i++)
                    {
                        double factor = Math.Pow(bits, result.Length - i - 1);
                        result[i] = (byte)(magnitude / factor);
                        magnitude -= result[i] * factor;
                    }

                    return result;
                }

                else
                {
                    if (magnitude == 0)
                    {
                        return new byte[] { 0 };
                    }

                    else
                    {
                        throw new ArgumentException("Toolbox.ByteArray.Vector: parameter must be greater than 0, double magnitude");
                    }
                }
            }

            else
            {
                throw new ArgumentException("Toolbox.ByteArray.Vector: parameter must be greater than 0, int bits");
            }
        }
    }
}
