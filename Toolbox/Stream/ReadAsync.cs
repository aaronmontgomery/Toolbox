using System.Threading.Tasks;
using System.Collections.Generic;

namespace Toolbox
{
    public static class Stream
    {
        public static async Task<IEnumerable<object>> ReadAsync(System.IO.Stream stream)
        {
            List<object> data = new List<object>();
            System.IO.StreamReader reader = new System.IO.StreamReader(stream);
            while (!reader.EndOfStream)
            {
                data.Add(await reader.ReadLineAsync());
            }

            return data;
        }
    }
}
