using System;
using System.Linq;
using System.IO;

public static class PathStorage
{
    public static void SavePath(Path newPath)
    {
        StreamWriter writePath = new StreamWriter("path-of-points.txt");
        using (writePath)
        {
            foreach (var point in newPath.ListOfPoints)
            {
                writePath.WriteLine(point);
            }
            writePath.WriteLine("");
        }
    }


    public static Path LoadPath()
    {
        Path loadedPath = new Path();

        StreamReader readPath = new StreamReader("path-of-points.txt");
        using (readPath)
        {
            string textLine = readPath.ReadLine();

            while (textLine != null)
            {
                if (textLine != "")
                {
                    string xCoord = textLine.Substring(26, 1);
                    string yCoord = textLine.Substring(33, 1);
                    string zCoord = textLine.Substring(40, 1);

                    Point3D currentPoint = new Point3D(int.Parse(xCoord), int.Parse(yCoord), int.Parse(zCoord));

                    loadedPath.AddingPoint(currentPoint);
                }
                textLine = readPath.ReadLine();
            }
        }
        return loadedPath;
    }
}
