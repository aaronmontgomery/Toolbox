namespace Toolbox
{
    public static partial class CharArray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string Remove(this string s, char[] items)
        {
            foreach (char c in items)
            {
                s = s.Replace(c.ToString(), string.Empty);
            }

            return s;
        }
    }
}
