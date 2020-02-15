using System.Collections.Generic;

namespace Toolbox
{
    public static class Stream
    {
        public static IEnumerable<object> Read(System.IO.Stream stream)
        {
            using System.IO.StreamReader reader = new System.IO.StreamReader(stream);
            List<object> data = new List<object>();
            while (!reader.EndOfStream)
            {
                data.Add(reader.ReadLine());
            }

            return data;
        }
    }
}
