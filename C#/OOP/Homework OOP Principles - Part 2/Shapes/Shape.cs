namespace Shapes
{
    public abstract class Shape
    {
        protected  decimal height;
        protected  decimal width;
        
        public abstract decimal CalculateSurface();
    }
}
