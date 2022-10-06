using System;

namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Adds byte arrays
        /// </summary>
        /// <param name="byteArray1"></param>
        /// <param name="byteArray2"></param>
        /// <returns></returns>
        public static byte[] Addition(byte[] byteArray1, byte[] byteArray2)
        {
            switch (byteArray1)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Addition: parameter cannot be null, byte[] byteArray1");
                case byte[] b when byteArray1.Length == 0:
                    throw new ArgumentException("Toolbox.ByteArray.Addition: parameter cannot be empty, byte[] byteArray1");
            }

            switch (byteArray2)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Addition:  parameter cannot be null, byte[] byteArray2");
                case byte[] b when byteArray2.Length == 0:
                    throw new ArgumentException("Toolbox.ByteArray.Addition: parameter cannot be empty, byte[] byteArray2");
            }

            return (byteArray1.Magnitude(256) + byteArray2.Magnitude(256)).Vector(256);
        }
    }
}
