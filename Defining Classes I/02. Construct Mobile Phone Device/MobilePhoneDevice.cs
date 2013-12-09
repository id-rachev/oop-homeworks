using System;

// Define several constructors for the defined classes
// that take different sets of arguments (the full information
// for the class or part of it). Assume that model and
// manufacturer are mandatory (the others are optional).
// All unknown data fill with null.

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

    static void Main()
    {
        Console.Write("Enter gsm model: ");
        string model = Console.ReadLine();
        Console.Write("Enter gsm manufacturer: ");
        string manufacturer = Console.ReadLine();

        try
        {
            MobilePhoneDevice myGsm = new MobilePhoneDevice(model, manufacturer);
            myGsm.model = "W200";
            myGsm.manufacturer = "Sony";
            myGsm.price = 180m;
            myGsm.Owner = "Icho";

            MobilePhoneDevice someGsm = new MobilePhoneDevice(model, manufacturer, 0, null, new Battery(), new Display());
            Battery someGsmBattery = new Battery();
            Display someGsmDisplay = new Display();

            Console.WriteLine("My gsm data: {0}, {1}, {2:C}, {3}.",
                myGsm.model, myGsm.manufacturer, myGsm.Price, myGsm.Owner);
            Console.WriteLine();

            Console.WriteLine("Some gsm data: {0}, {1}, {2}, {3}.\nSome gsm {4}: {5}, {6}, {7}.\nSome gsm {8}: {9}, {10}.",
                someGsm.model, someGsm.manufacturer, someGsm.Price,
                someGsm.Owner, someGsm.gsmBattery, someGsm.gsmBattery.BatteryModel , someGsm.gsmBattery.HoursIdle,
                someGsm.gsmBattery.HoursTalk, someGsm.gsmDisplay, someGsm.gsmDisplay.Size, someGsm.gsmDisplay.ColorsNumber);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Cannot create gsm object: " + ex);
        }


    }
}
