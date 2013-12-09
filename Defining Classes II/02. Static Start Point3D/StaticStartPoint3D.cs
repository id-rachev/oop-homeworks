using System;
using System.Linq;

// Add a private static read-only field to hold the start
// of the coordinate system – the point O{0, 0, 0}.
// Add a static property to return the point O.

public struct StaticStartPoint3D
{
    static void Main()
    {
        Console.WriteLine(Point3D.StartPoint3D);
    }
}
