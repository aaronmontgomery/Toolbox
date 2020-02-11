using System;
using System.Linq;
using System.Collections.Generic;

namespace Toolbox.Files
{
    public static partial class M3u
    {
        /// <summary>
        /// Format m3u filelines into a list of FileLine objects
        /// </summary>
        public static IEnumerable<FileLine> ParseFileLines(string path)
        {
            List<FileLine> r = new List<FileLine>();
            string[] lines = System.IO.File.ReadAllLines(path).Where(fileLine => fileLine != string.Empty).ToArray();
            for (int i = 1; i < lines.Count(); i++)
            {
                string[] songArtist = lines[i].Remove(0, lines[i].IndexOf(',') + 1).Split(new string[] { " - " }, StringSplitOptions.None);
                r.Add(new FileLine(songArtist[0], songArtist[1], lines[i + 1]));
                i++;
            }

            return r;
        }
    }
}
