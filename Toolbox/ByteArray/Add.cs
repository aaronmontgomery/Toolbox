namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Adds byte arrays
        /// </summary>
        /// <param name="byte1"></param>
        /// <param name="byte2"></param>
        /// <returns>byte[]</returns>
        public static byte[] Add(byte[] byte1, byte[] byte2)
        {
            return (byte1.Magnitude(256) + byte2.Magnitude(256)).Vector(256);
        }
    }
}
