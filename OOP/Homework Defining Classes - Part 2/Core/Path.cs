using System.Collections.Generic;
namespace Core
{
    public class Path
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public  List<Point3D> sequenceOfPoints{ get; set; }
        public Path(Point3D point)
        {
            this.sequenceOfPoints = new List<Point3D>();
            this.sequenceOfPoints.Add(point);
            this.x = point.x;
            this.y = point.y;
            this.z = point.z;
        }
        public void PutPoints(Point3D point)
        {
            this.sequenceOfPoints.Add(point);
            this.x = point.x;
            this.y = point.y;
            this.z = point.z;
        }
        public override string ToString()
        {
            return string.Format("From text file:  X:{0} Y:{1} Z:{2}",this.x,this.y,this.z);
        }
    }
}
