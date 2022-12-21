using System;

namespace лб9._1
{
    class Program
    {
        abstract class Shape
        {
            public string Name { get; }
            public string Color { get; set; }
            public int Vertices { get; }

            protected Shape(string name, int vertices)
            {
                Name = name;
                Vertices = vertices;
                Color = GetRandomColor();
            }

            public abstract double GetArea();
            public abstract double GetPerimeter();

            private static string GetRandomColor()
            {
                string[] colors = { "red", "orange", "yellow", "green", "blue", "purple" };
                Random random = new Random();
                int index = random.Next(colors.Length);
                return colors[index];
            }
        }

        class Pentagon : Shape
        {
            public double SideLength { get; }

            public Pentagon(string name, double sideLength) : base(name, 5)
            {
                SideLength = sideLength;
            }

            public override double GetArea()
            {
                return (5 * Math.Pow(SideLength, 2)) / (4 * Math.Tan(Math.PI / 5));
            }

            public override double GetPerimeter()
            {
                return SideLength * 5;
            }
        }

        class Ellipse : Shape
        {
            public double SemiAxisA { get; }
            public double SemiAxisB { get; }

            public Ellipse(string name, double semiAxisA, double semiAxisB) : base(name, 0)
            {
                SemiAxisA = semiAxisA;
                SemiAxisB = semiAxisB;
            }

            public override double GetArea()
            {
                return Math.PI * SemiAxisA * SemiAxisB;
            }

            public override double GetPerimeter()
            {
                return Math.PI * (3 * (SemiAxisA + SemiAxisB) -
                                 Math.Sqrt((3 * SemiAxisA + SemiAxisB) * (SemiAxisA + 3 * SemiAxisB)));
            }
        }

        class Triangle : Shape
        {
            public double LegA { get; }
            public double LegB { get; }

            public Triangle(string name, double legA, double legB) : base(name, 3)
            {
                LegA = legA;
                LegB = legB;
            }

            public override double GetArea()
            {
                return 0.5 * LegA * LegB;
            }

            public override double GetPerimeter()
            {
                return LegA + LegB + Math.Sqrt(Math.Pow(LegA, 2) + Math.Pow(LegB, 2));
            }
        }
    }
}
