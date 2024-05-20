using System;
public static class Darts
{
    public static int Score(double x, double y)
    {
        double radius = Math.Sqrt((x*x)+(y*y));
		switch (radius)
		{
				case<=1:
					return 10;
				case<=5 when radius>1:
					return 5;
				case<=10 when radius>5:
					return 1;
				case>10:
					return 0;
				default:
					return 0;
		}
    }
}
