using System.Collections.Generic;

namespace ShapeFactory
{
    public interface IShapeFactory
    {
        List<string> AvailableShapes { get; }
        IShape Create(string name);
    }
}
