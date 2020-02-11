namespace Toolbox
{
    public static partial class ByteArray
    {
        /// <summary>
        /// Inserts zero values at beginning indices
        /// </summary>
        public static byte[] InsertLeadingZeros(byte[] b, int length)
        {
            byte[] r = new byte[length];
            b.CopyTo(r, r.Length - b.Length);
            return r;
        }
    }
}