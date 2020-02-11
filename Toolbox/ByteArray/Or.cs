namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Performs bitwise OR operation
        /// </summary>
        public static byte[] Or(byte[] b1, byte[] b2)
        {
            byte[] r = new byte[b1.Length];
            for (int i = 0; i < b1.Length; i++)
            {
                r[i] = (byte)((int)b1[i] | (int)b2[i]);
            }

            return r;
        }
    }
}