using System;

public class Display
{
    private float size;
    private string colorsNumber;

    public Display()
    {
    }

    public Display(float size)
        : this(size, null)
    {
    }

    public Display(float size, string colorsNumber)
    {
        this.size = size;
        this.colorsNumber = colorsNumber;
    }

    public float Size
    {
        get { return size; }
        set { size = value; }
    }

    public string ColorsNumber
    {
        get { return colorsNumber; }
        set { colorsNumber = value; }
    }

}
