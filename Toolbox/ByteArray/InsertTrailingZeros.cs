namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Inserts zero values at ending indices
        /// </summary>
        public static byte[] InsertTrailingZeros(byte[] b, int length)
        {
            byte[] r = new byte[length];
            b.CopyTo(r, 0);
            return r;
        }
    }
}
