using System;

public class Battery
{
    private string batteryModel;
    private float hoursIdle;
    private float hoursTalk;

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