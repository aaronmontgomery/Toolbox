using System;
using System.Text;

namespace Toolbox.Cryptography
{
    public static partial class Sha512
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GenerateSalt()
        {
            return Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(string.Concat(new Random().Next(), DateTime.Now.AddMilliseconds(new Random().Next()).Ticks)));
        }
    }
}
