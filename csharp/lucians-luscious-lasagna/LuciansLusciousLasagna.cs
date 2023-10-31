class Lasagna
{   
    private readonly int _minutesInOven = 40;
    private readonly int _preparationMinutesPerLayer = 2;
    public int ExpectedMinutesInOven() => _minutesInOven;
    public int RemainingMinutesInOven(int minutes) => _minutesInOven - minutes;
    public int PreparationTimeInMinutes(int layers) => layers * _preparationMinutesPerLayer;
    public int ElapsedTimeInMinutes(int layers, int minutesInOven) {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }

}
