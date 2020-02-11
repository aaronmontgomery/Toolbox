namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Performs bitwise NOT operation unsigned
        /// </summary>
        public static byte[] Not(this byte[] b)
        {
            byte[] r = new byte[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                r[i] = (byte)~b[i];
            }

            return r;
        }
    }
}