using System;
using System.Linq;

class StaticFieldIPhone4S
{
    // Add a static field and a property IPhone4S in the GSM class
    // to hold the information about iPhone 4S.

    class MobilePhoneDevice
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        Battery gsmBattery = new Battery();
        Display gsmDisplay = new Display();

        private static MobilePhoneDevice iphone4S;
        public static MobilePhoneDevice IPhone4S
        {
            get { return iphone4S; }
        }

        static MobilePhoneDevice()
        {
            iphone4S = new MobilePhoneDevice("IPhone 4S", "Apple");
        }

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
        Console.WriteLine(MobilePhoneDevice.IPhone4S);
    }
}