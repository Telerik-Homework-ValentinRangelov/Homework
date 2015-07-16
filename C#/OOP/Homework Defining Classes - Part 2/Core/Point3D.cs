
namespace Core
{
    public struct Point3D
    {
        private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        

        public Point3D(double x, double y, double z) :this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {

            return string.Format("X:{0} Y:{1} Z:{2}", x, y, z);
        }
        public static Point3D ReturnThePointO
        {
            get
            {

                return zeroPoint;
            }
        }
    }
}
