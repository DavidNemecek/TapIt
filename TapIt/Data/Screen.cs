using System.Collections.Generic;

namespace TapIt.Data
{
    /// <summary>
    /// Properties of the Screen including Circle Dimensions and Circles
    /// </summary>
    public class Screen
    {
        public List<Circle> Circles = new List<Circle>();
        public int Width { get; set; }
        public int Height { get; set; }
        public int MaxCircleSize => (Height / 150) * (Width / 150);
        public int MinCircleSize => (Height / 300) * (Width / 300);

        public Screen(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
