using System;

namespace Toolbox
{
    public static partial class CharArray
    {
        /// <summary>
        /// Returns a new string with characters removed
        /// </summary>
        /// <param name="s">The string to be modified</param>
        /// <param name="charsToRemove">The characters to be removed</param>
        public static string Remove(this string s, char[] charsToRemove)
        {
            switch (s)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Remove: parameter cannot be null, string s");
            }

            switch (charsToRemove)
            {
                case null:
                    throw new ArgumentNullException("Toolbox.ByteArray.Remove: parameter cannot be null, char[] charsToRemove");
            }

            foreach (char c in charsToRemove)
            {
                s = s.Replace(c.ToString(), string.Empty);
            }
            
            return s;
        }
    }
}
