using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Bitwise OR operation
        /// </summary>
        /// <param name="byteArray1"></param>
        /// <param name="byteArray2"></param>
        /// <returns></returns>
        public static byte[] Or(byte[] byteArray1, byte[] byteArray2)
        {
            switch (byteArray1)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Or: parameter cannot be null, byte[] byteArray1");
                case byte[] b when byteArray1.Length == 0:
                    throw new ArgumentException("Toolbox.ByteArray.Or: parameter cannot be empty, byte[] byteArray1");
            }

            switch (byteArray2)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Or: parameter cannot be null, byte[] byteArray2");
                case byte[] b when byteArray2.Length == 0:
                    throw new ArgumentException("Toolbox.ByteArray.Or: parameter cannot be empty, byte[] byteArray2");
            }

            byte[] result = new byte[byteArray1.Length];
            for (int i = 0; i < byteArray1.Length; i++)
            {
                result[i] = (byte)((int)byteArray1[i] | (int)byteArray2[i]);
            }

            return result;
        }
    }
}
