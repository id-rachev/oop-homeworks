using System;
using System.Collections.Generic;
using System.Linq;

public class Path
{
    private readonly List<Point3D> listOfPoints = new List<Point3D>();

    public List<Point3D> ListOfPoints
    {
        get { return listOfPoints; }
    }

    public Path()
    {
    }

    public Path(Point3D firstPoint)
        : this(firstPoint, new Point3D())
    {
    }

    public Path(Point3D firstPoint, Point3D secondPoint)
        : this(firstPoint, secondPoint, new Point3D())
    {
    }

    public Path(Point3D firstPoint, Point3D secondPoint, Point3D thirdPoint)
    {
        this.ListOfPoints.Add(firstPoint);
        this.ListOfPoints.Add(secondPoint);
        this.ListOfPoints.Add(thirdPoint);
    }

    public void AddingPoint(Point3D newPoint)
    {
        ListOfPoints.Add(newPoint);
    }

    public void PrintEntirePath()
    {
        foreach (Point3D point in ListOfPoints)
        {
            Console.WriteLine(point);
        }
        Console.WriteLine();
    }
}
