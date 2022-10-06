using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Bitwise NOT operation
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        public static byte[] Not(this byte[] byteArray)
        {
            switch (byteArray)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Not: parameter cannot be null, byte[] byteArray");
                case byte[] b when byteArray.Length == 0:
                    throw new ArgumentException("Toolbox.ByteArray.Not: parameter cannot be empty, byte[] byteArray");
            }

            byte[] result = new byte[byteArray.Length];
            for (int i = 0; i < byteArray.Length; i++)
            {
                result[i] = (byte)~byteArray[i];
            }

            return result;
        }
    }
}
