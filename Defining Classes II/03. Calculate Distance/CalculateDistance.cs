using System;
using System.Linq;

// Write a static class with a static method to calculate
// the distance between two points in the 3D space.

static class CalculateDistance
{
    private static double distance;


    public static double CalcDist(Point3D firstPoint, Point3D secondPoint)
    {
        int deltaX = firstPoint.XCoord - secondPoint.XCoord;
        int deltaY = firstPoint.YCoord - secondPoint.YCoord;
        int deltaZ = firstPoint.ZCoord - secondPoint.ZCoord;

        distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance;
    }

    static void Main()
    {
        Point3D firstPoint = new Point3D(9, 2, 0);
        Point3D secondPoint = new Point3D(1, 6, 9);

        Console.WriteLine(CalculateDistance.CalcDist(firstPoint, secondPoint));
    }
}
