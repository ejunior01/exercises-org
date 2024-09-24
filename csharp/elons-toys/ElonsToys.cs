using System;

class RemoteControlCar
{
    private int _drivenMeters = 0;
    private double _battery = 100d;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay() => $"Driven {_drivenMeters} meters";

    public string BatteryDisplay() => _battery == 0 ? "Battery empty" : $"Battery at {_battery}%";

    public void Drive()
    {
        if (_battery != 0)
        {
            _drivenMeters += 20;
            _battery -= 1d;
        }
    }
}
