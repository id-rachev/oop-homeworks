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
        set
        {
            // if (value == 0f) throw new ArgumentException("Display size cannot be empty!");
            if (value < 1.5f)
            {
                throw new ArgumentException("Display size cannot be smaller than 1.5 inches!");
            }
            this.size = value;
        }
    }

    public string ColorsNumber
    {
        get { return colorsNumber; }
        set
        {
            // if (value == null) throw new ArgumentException("Display colors number cannot be empty!");
            if ((value != null) && (value.Length < 2))
            {
                throw new ArgumentException("Display colors number cannot be less than 2 symbols!");
            }
            this.colorsNumber = value;
        }
    }

}
