using System;
using System.Linq;

class EncapsulateAndValidation
{
    // Use properties to encapsulate the data fields inside the GSM, Battery and
    // Display classes. Ensure all fields hold correct data at any given time.

    class MobilePhoneDevice
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

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
                if (value.Length < 2)
                {
                    throw new ArgumentException("Model name cannot be less than 2 symbols!");
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
                if (value.Length < 2)
                {
                    throw new ArgumentException("Manufacturer name cannot be less than 2 symbols!");
                }
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                // if (value == 0) throw new ArgumentException("Price cannot be empty!");
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                // if (value == null) throw new ArgumentException("Owner cannot be empty!");
                if ((value != null) && (value.Length < 2))
                {
                    throw new ArgumentException("Owner name cannot be less than 2 symbols!");
                }
                this.owner = value;
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

    }

    static void Main()
    {
        MobilePhoneDevice someGsm = new MobilePhoneDevice(
            "W200", "Sony", 180, "Icho", new Battery("BatMod35", 48.5f, 2.5f, new BatteryType()), new Display(3.5f, "64k"));

        Console.WriteLine(someGsm);

    }
}
