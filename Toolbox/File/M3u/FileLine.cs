namespace Toolbox.Files
{
    public static partial class M3u
    {
        /// <summary>
        /// M3u fileline object
        /// </summary>
        public class FileLine
        {
            public string Artist { get; set; }
            public string Song { get; set; }
            public string FilePath { get; set; }
            public FileLine(string song, string artist, string filePath)
            {
                Song = song;
                Artist = artist;
                FilePath = filePath;
            }
        }
    }
}
