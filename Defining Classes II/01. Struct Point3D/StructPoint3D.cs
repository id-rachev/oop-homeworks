using System;
using System.Linq;

// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z}
// in the Euclidian 3D space. Implement the ToString() to enable
// printing a 3D point.

class StructPoint3D
{
    static void Main()
    {
        Console.Write("Enter coordinates for 3D point.\nX = ");
        int xPoint = int.Parse(Console.ReadLine());

        Console.Write("Y = ");
        int yPoint = int.Parse(Console.ReadLine());

        Console.Write("Z = ");
        int zPoint = int.Parse(Console.ReadLine());

        Point3D userPoint3D = new Point3D(xPoint, yPoint, zPoint);

        Console.WriteLine(userPoint3D);
    }
}
