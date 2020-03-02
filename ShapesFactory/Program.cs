using System;
using System.Collections.Generic;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();

            IShapeFactory factory = new ShapeFactory();
            foreach(var shapeName in factory.AvailableShapes)
            {
                var shape = factory.Create(shapeName);
                shapes.Add(shape);
            }

            foreach(var shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadKey();
        }
    }
}
