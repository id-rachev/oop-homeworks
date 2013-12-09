using System;

// Define a class that holds information about a mobile phone
// device: model, manufacturer, price, owner, battery characteristics
// (model, hours idle and hours talk) and display characteristics
// (size and number of colors). Define 3 separate classes
// (class GSM holding instances of the classes Battery and Display).

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

    static void Main()
    {
    }
}