using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Toolbox
{
    public static class Image
    {
        public static byte[] CaptureScreen()
        {
            Rectangle screen = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(screen.Width, screen.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap)) { graphics.CopyFromScreen(Point.Empty, Point.Empty, screen.Size); }
                MemoryStream stream = new MemoryStream();
                bitmap.Save(stream, ImageFormat.Png);
                byte[] buffer = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(buffer, 0, (int)stream.Length);
                return buffer;
            }
        }
    }
}
