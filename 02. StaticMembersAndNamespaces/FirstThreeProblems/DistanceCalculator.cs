using System;

namespace Point3D
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2) + Math.Pow(secondPoint.Z - firstPoint.Z, 2);
            distance = Math.Sqrt(distance);
            return distance;
        }
    }
}
