using System;
using System.Drawing;
using System.Collections.Generic;

namespace лб9._3
{
    class Program
    {
        public interface IDraw
        {
            void Draw();
        }

        public class Shape : IDraw
        {
            public string Name { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public Color Color { get; set; }

            public void Draw()
            {
                Console.ForegroundColor = Color;
                Console.WriteLine($"Displaying shape: {Name} with dimensions {Width}x{Height}");
            }
        }

        public class Painter
        {
            public static void DrawShape(IDraw shape)
            {
                shape.Draw();
            }
        }

        class Prog
        {
            static void Main(string[] args)
            {
                Shape triangle = new Shape { Name = "Triangle", Width = 100, Height = 100, Color = Color.Blue };
                Painter.DrawShape(triangle);
            }
        }
    }
}

