namespace Shapes
{
    public class Rectangle : Shape
    {
        
        public Rectangle(decimal height, decimal width)
        {
            base.height = height;
            base.width = width;
        }
        public override decimal CalculateSurface()
        {
            return this.height * this.width;
        }
    }
}
