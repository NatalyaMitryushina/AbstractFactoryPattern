using System;
using System.Collections.Generic;

namespace ShapeFactory
{
    class ShapeFactory : IShapeFactory
    {
        public List<string> AvailableShapes { get; } 
            = new List<string> { nameof(Circle), nameof(Square) };

        public IShape Create(string name)
        {
            if (name.Equals("Circle"))
                return new Circle();
            else if (name.Equals("Square"))
                return new Square();
            else
                throw new Exception($"ShapeFactory can't create: {name}");
        }
    }
}
