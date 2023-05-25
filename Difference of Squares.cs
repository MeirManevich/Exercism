using System;
public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int counter = 0;
        int sum=0;
        while(counter<=max)
        {
            sum +=counter;
            counter++;
        }
		int square = sum*sum;
		return square;
    }
    public static int CalculateSumOfSquares(int max)
    {
        int counter = 0;
        int sum=0;
        while(counter<=max)
        {
            sum +=counter*counter;
            counter++;
        }
		return sum;
    }
    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max)-CalculateSumOfSquares(max);
    }
}