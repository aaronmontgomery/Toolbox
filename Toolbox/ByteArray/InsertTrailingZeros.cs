using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Inserts zero values in last indices
        /// </summary>
        /// <param name="byteArray"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] InsertTrailingZeros(byte[] byteArray, int length)
        {
            switch (byteArray)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.InsertTrailingZeros: parameter cannot be null, byte[] byteArray");
                case byte[] b when byteArray.Length == 0:
                    throw new ArgumentException("Toolbox.ByteArray.InsertTrailingZeros: parameter cannot be empty, byte[] byteArray");
            }

            if (length > byteArray.Length)
            {
                byte[] result = new byte[length];
                byteArray.CopyTo(result, 0);
                return result;
            }

            else
            {
                return byteArray;
            }
        }
    }
}
