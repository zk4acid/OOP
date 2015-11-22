using System;

namespace Point3D
{
    public class MainProgram
    {
        public const string filePath = "../../path.txt";

        public static void Main(string[] args)
        {
            Point3D point = new Point3D(2.5, 1, 3);
            Point3D startingPoint = Point3D.GetStartingPoint;

            //Homework Problem 1
            //Print point
            Console.WriteLine(point.ToString());

            //Homework Problem 1
            //Print starting point
            Console.WriteLine(startingPoint.ToString());

            //Homework Problem 2
            //Calculate and print dostance between point and starting point
            Console.WriteLine(DistanceCalculator.CalculateDistance(point, startingPoint));

            //Homework Problem 3
            //Create path and add two points
            Path3D path = new Path3D();
            path.AddPoint(point);
            path.AddPoint(startingPoint);

            //Save file
            Storage.SavePath(path, filePath);

            //Load file
            Console.WriteLine();
            Storage.LoadPath(filePath);
        }
    }
}