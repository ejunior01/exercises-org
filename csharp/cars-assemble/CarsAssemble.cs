using System;

static class AssemblyLine
{
    private const int WorkingItems = 221;
    public static double SuccessRate(int speed)
    {

        if (speed == 0) return 0;
        if (speed >= 1 && speed < 5) return 1.0;
        if (speed >= 5 && speed < 9) return 0.9;
        if (speed == 9) return 0.8;
        if (speed == 10) return 0.77;
        return 0;
    }

    public static double ProductionRatePerHour(int speed)
    {

        var successRate = SuccessRate(speed);
        var produced = WorkingItems * speed;
        return produced * successRate;
    }

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}