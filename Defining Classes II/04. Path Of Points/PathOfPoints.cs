using System;
using System.Collections.Generic;
using System.Linq;

class PathOfPoints
{
    // Create a class Path to hold a sequence of points in the
    // 3D space. Create a static class PathStorage with static
    // methods to save and load paths from a text file.
    // Use a file format of your choice.

    static void Main()
    {
        Point3D firstPoint = new Point3D();
        Point3D secondPoint = new Point3D(1, 3, 7);
        Point3D thirdPoint = new Point3D(3, 4, 2);

        Path myOwnPath = new Path(firstPoint, secondPoint, thirdPoint);

        myOwnPath.PrintEntirePath();
        PathStorage.SavePath(myOwnPath);

        Path loadedPath = PathStorage.LoadPath();
        loadedPath.PrintEntirePath();
    }
}
