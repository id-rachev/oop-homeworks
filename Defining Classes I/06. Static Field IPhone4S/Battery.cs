using System;

public enum BatteryType
{
    LiIon, NiMH, NiCd
}

public class Battery
{
    private string batteryModel;
    private float hoursIdle;
    private float hoursTalk;
    private BatteryType batteryType;

    public Battery()
    {
    }

    public Battery(string batteryModel)
        : this(batteryModel, 0.0f, 0.0f)
    {
    }

    public Battery(string batteryModel, float hoursIdle, float hoursTalk)
        : this(batteryModel, hoursIdle, hoursTalk, 0)
    {
    }

    public Battery(string batteryModel, float hoursIdle, float hoursTalk, BatteryType batteryType)
    {
        this.batteryModel = batteryModel;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.batteryType = batteryType;
    }

    public string BatteryModel
    {
        get { return batteryModel; }
        set
        {
            // if (value == null) throw new ArgumentException("Battery model name cannot be empty!");
            if ((value != null) && (value.Length < 2))
            {
                throw new ArgumentException("Battery model name cannot be less than 2 symbols!");
            }
            this.batteryModel = value;
        }
    }

    public float HoursIdle
    {
        get { return hoursIdle; }
        set
        {
            // if (value == 0f) throw new ArgumentException("Battery hours idle cannot be empty!");
            if (value < 12f)
            {
                throw new ArgumentException("Battery hours-idle cannot be smaller than 12 hours!");
            }
            this.hoursIdle = value;
        }
    }

    public float HoursTalk
    {
        get { return hoursTalk; }
        set
        {
            // if (value == 0f) throw new ArgumentException("Battery hours talk cannot be empty!");
            if (value < 1f)
            {
                throw new ArgumentException("Battery hours-talk cannot be smaller than 1 hour!");
            }
            this.hoursTalk = value;
        }
    }

    public BatteryType BatteryType
    {
        get { return batteryType; }
    }


}