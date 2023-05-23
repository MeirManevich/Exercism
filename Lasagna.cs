class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    public int RemainingMinutesInOven(int currentBakeTime)
    {
        return (40-currentBakeTime);
    }
    public int PreparationTimeInMinutes(int layers)
    {
        return (2*layers);
    }
    public int ElapsedTimeInMinutes(int layers, int currentBakeTime)
    {
        return((2*layers)+currentBakeTime);
    }
}
