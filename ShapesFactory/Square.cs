using System;

namespace ShapeFactory
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square was added");
        }
    }
}
