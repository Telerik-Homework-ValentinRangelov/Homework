namespace Core
{
   public static class DistanceBetweenTwoPoints
    {
       public static string DistanceBetweenTheTwoPoints(Point3D firstPoint,Point3D secondPoint)
       {
           double xDistance = firstPoint.x - secondPoint.x;
           double yDistance = firstPoint.y - secondPoint.y;
           double zDistance = firstPoint.z - secondPoint.z;
           return string.Format("The distance between the two points are X:{0} Y:{1} Z:{2}", xDistance, yDistance, zDistance);

       }
    }
}
