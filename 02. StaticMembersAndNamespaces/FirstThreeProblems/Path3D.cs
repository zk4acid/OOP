using System;
using System.Collections.Generic;

namespace Point3D
{
    public class Path3D
    {
        private List<Point3D> listOfPoints = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            listOfPoints.Add(point);
        }

        public override string ToString()
        {
            string print = "Path:" + Environment.NewLine;
            print += Environment.NewLine;
            foreach (Point3D point in listOfPoints)
            {
                print += "- Point: " + Environment.NewLine;
                print += "--> X: " + point.X + Environment.NewLine;
                print += "--> Y: " + point.Y + Environment.NewLine;
                print += "--> Z: " + point.Z + Environment.NewLine;
                print += Environment.NewLine;
            }
            return print;
        }
    }
}
