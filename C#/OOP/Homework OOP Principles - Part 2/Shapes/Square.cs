namespace Shapes
{
    public class Square : Shape
    {
       

        public Square(decimal squareSide)
        {
            base.height = squareSide;
            base.width = squareSide;
        }

        public override decimal CalculateSurface()
        {
            return base.height * base.width;
        }
    }
}
