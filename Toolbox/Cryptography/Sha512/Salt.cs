using System;
using System.Text;

namespace Toolbox.Cryptography
{
    public static partial class Sha512
    {
        /// <summary>
        /// Generate salt to be used with hash for enhanced security
        /// </summary>
        /// <returns></returns>
        public static string Salt()
        {
            return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(string.Concat(new Random().Next(), DateTime.Now.AddMilliseconds(new Random().Next()).Ticks)));
        }
    }
}
