using System;
using System.Linq;

public struct Point3D
{
    public int XCoord { get; set; }
    public int YCoord { get; set; }
    public int ZCoord { get; set; }

    public Point3D(int xCoord, int yCoord, int zCoord)
        : this()
    {
        this.XCoord = xCoord;
        this.YCoord = yCoord;
        this.ZCoord = zCoord;
    }

    public override string ToString()
    {
        string point3DtoString = string.Format(
            "Point 3D coordinates: X = {0}, Y = {1}, Z = {2}.",
            XCoord, YCoord, ZCoord);
        return point3DtoString;
    }
}