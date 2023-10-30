public class Lasagna {
    public int expectedMinutesInOven()
    {
        return 40;
    }
    public int remainingMinutesInOven (int timeCooked)
    {
        return 40-timeCooked;
    }
    public int preparationTimeInMinutes(int layers)
    {
        return 2*layers;
    }
    public int totalTimeInMinutes(int layers, int timeCooked)
    {
        return (timeCooked)+(2*layers);
    }
}
