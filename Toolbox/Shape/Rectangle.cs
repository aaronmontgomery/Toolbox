namespace Toolbox.Shapes
{
    public class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle()
        {
            Length = 1;
            Width = 1;
            Height = 1;
        }

        public Rectangle(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}
