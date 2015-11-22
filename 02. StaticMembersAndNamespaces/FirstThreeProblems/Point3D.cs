namespace Point3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D GetStartingPoint
        {
            get { return StartingPoint; }
        }

        public override string ToString()
        {
            string print = "Point X: " + this.X + "\n\r";
            print += "Point Y: " + this.Y + "\n\r";
            print += "Point Z: " + this.Z + "\n\r";
            return print;
        }
    }
}
