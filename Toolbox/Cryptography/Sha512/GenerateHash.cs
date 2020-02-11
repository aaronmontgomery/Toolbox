using System.Text;
using System.Security.Cryptography;

namespace Toolbox.Cryptography
{
    public static partial class Sha512
    {
        /// <summary>
        /// 
        /// </summary>
        public static string GenerateHash(string password, string salt)
        {
            using SHA512Managed sha = new SHA512Managed();
            return Encoding.UTF8.GetString(sha.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(password, salt))));
        }
    }
}
