using System;
using System.Collections.Generic;
using System.Windows.Shapes;

namespace лб9._2
{
    class Program
    {
        public class Picture
        {
            private List<Shape> shapes;

            public Picture()
            {
                shapes = new List<Shape>();
            }

            public Picture(int length)
            {
                shapes = new List<Shape>(length);
            }
            public int Count => shapes.Count;

            public void AddShape(Shape shape)
            {
                shapes.Add(shape);
            }
            public void DeleteShapeByName(string name)
            {
                shapes.RemoveAll(s => s.Name == name);
            }

            public void DeleteShapeByType(Type type)
            {
                shapes.RemoveAll(s => s.GetType() == type);
            }
            public void DeleteShapeByArea(double maxArea)
            {
                shapes.RemoveAll(s => s.Area > maxArea);
            }

            public Shape this[int index]
            {
                get { return shapes[index]; }
                set { shapes[index] = value; }
            }

        }
    }
}
