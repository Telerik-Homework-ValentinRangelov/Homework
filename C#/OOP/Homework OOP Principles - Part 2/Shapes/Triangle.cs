namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(decimal height,decimal width)
        {
            base.height = height;
            base.width = width;
        }
        public override decimal CalculateSurface()
        {
            return (base.height * base.width) / 2;
        }
    }
}
