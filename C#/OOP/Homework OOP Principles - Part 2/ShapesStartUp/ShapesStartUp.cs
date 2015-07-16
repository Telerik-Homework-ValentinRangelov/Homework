using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ShapesStartUp
{
    class ShapesStartUp
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(5, 30));
            shapes.Add(new Square(10));
            shapes.Add(new Triangle(8,12));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
                
            }

        }
    }
}
