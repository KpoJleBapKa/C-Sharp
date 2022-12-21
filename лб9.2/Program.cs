using System;
using System.Collections.Generic;
using System.Windows.Shapes;

namespace лб9._2
{
    class Program
    {
        public class Picture
        {
            // The collection of shapes in the picture
            private List<Shape> shapes;

            // Constructors
            public Picture()
            {
                shapes = new List<Shape>();
            }

            public Picture(int length)
            {
                shapes = new List<Shape>(length);
            }

            // Property to get the number of elements in the collection
            public int Count => shapes.Count;

            // Method to add a new shape to the collection
            public void AddShape(Shape shape)
            {
                shapes.Add(shape);
            }

            // Method to delete a shape from the collection by name
            public void DeleteShapeByName(string name)
            {
                shapes.RemoveAll(s => s.Name == name);
            }

            // Method to delete a shape from the collection by type
            public void DeleteShapeByType(Type type)
            {
                shapes.RemoveAll(s => s.GetType() == type);
            }

            // Method to delete a shape from the collection if it exceeds a given area
            public void DeleteShapeByArea(double maxArea)
            {
                shapes.RemoveAll(s => s.Area > maxArea);
            }

            // Indexer to get an element from the collection by index
            public Shape this[int index]
            {
                get { return shapes[index]; }
                set { shapes[index] = value; }
            }

        }
    }
}
