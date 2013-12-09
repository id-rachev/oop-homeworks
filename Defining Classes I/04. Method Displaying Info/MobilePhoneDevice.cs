using System;

// Add a method in the GSM class for displaying
// all information about it. Try to override ToString().

class MobilePhoneDevice
{
    private string model;
    private string manufacturer;
    private decimal price;
    public string Owner { get; set; }

    Battery gsmBattery = new Battery();
    Display gsmDisplay = new Display();

    public string Model
    {
        get { return model; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model name cannot be empty!");
            }
            this.model = value;
        }
    }
    public string Manufacturer
    {
        get { return manufacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Manufacturer name cannot be empty!");
            }
            this.manufacturer = value;
        }
    }
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative!");
            }
            this.price = value;
        }
    }

    public MobilePhoneDevice(string model, string manufacturer)
        : this(model, manufacturer, 0, null)
    {
    }

    public MobilePhoneDevice(string model, string manufacturer,
        decimal price, string owner)
        : this(model, manufacturer, price, owner, new Battery(), new Display())
    {
    }

    public MobilePhoneDevice(string model, string manufacturer,
        decimal price, string owner, Battery gsmBattery, Display gsmDisplay)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.gsmBattery = gsmBattery;
        this.gsmDisplay = gsmDisplay;
    }

    public override string ToString()
    {
        return string.Format("Some gsm data: {0}, {1}, {2:C}, {3}.\nSome gsm {4}: {5}, {6}h, {7}h, {8}.\nSome gsm {9}: {10}in, {11}.",
                this.model, this.manufacturer, this.Price,
                this.Owner, this.gsmBattery, this.gsmBattery.BatteryModel, this.gsmBattery.HoursIdle,
                this.gsmBattery.HoursTalk, this.gsmBattery.BatteryType, this.gsmDisplay, this.gsmDisplay.Size, this.gsmDisplay.ColorsNumber);
    }

    static void Main()
    {
        MobilePhoneDevice someGsm = new MobilePhoneDevice(
            "W200", "Sony", 180, "Icho", new Battery("BatMod35", 48.5f, 2.5f, BatteryType.NiMH), new Display(3.5f, "64k"));

        Console.WriteLine(someGsm);

    }
}
