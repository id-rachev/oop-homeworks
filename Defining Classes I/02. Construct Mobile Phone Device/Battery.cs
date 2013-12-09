using System;

public class Battery
{
    private string batteryModel;
    private float hoursIdle;
    private float hoursTalk;

    public Battery()
    {
    }

    public Battery(string batteryModel)
        : this(batteryModel, 0.0f, 0.0f)
    {
    }

    public Battery(string batteryModel, float hoursIdle, float hoursTalk)
    {
        this.batteryModel = batteryModel;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
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


}