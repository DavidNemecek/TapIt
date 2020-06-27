using System;

namespace TapItWA.Data
{
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public string Fill { get; set; }

        public Circle(int x, int y, int r, string fill)
        {
            X = x;
            Y = y;
            Size = r;
            Fill = fill;
        }

        /// <summary>
        /// Create a Circle with Random Parameters
        /// </summary>
        /// <param name="s">Screen</param>
        /// <returns>Returns a Circle with Random Parameters</returns>
        public static Circle RandomCircleGenerator(Screen s)
        {
            var rand = new Random();
            return new Circle(rand.Next(s.Width),
                rand.Next(s.Height),
                rand.Next(s.MinCircleSize, s.MaxCircleSize),
                "#" + rand.Next(0,256).ToString("X2") + rand.Next(0, 256).ToString("X2") + rand.Next(0, 256).ToString("X2"));
        }
    }
}