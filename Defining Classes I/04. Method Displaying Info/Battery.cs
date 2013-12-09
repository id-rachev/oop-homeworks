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
        set { batteryModel = value; }
    }

    public float HoursIdle
    {
        get { return hoursIdle; }
        set { hoursIdle = value; }
    }

    public float HoursTalk
    {
        get { return hoursTalk; }
        set { hoursTalk = value; }
    }

    public BatteryType BatteryType
    {
        get { return batteryType; }
    }


}