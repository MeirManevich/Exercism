using System;

public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
		if(side1+side2>=side3&&side2+side3>=side1&&side1+side3>=side2&&side1+side2+side3!=0)
		{
			return side1!=side2 && side1!=side3 && side2!=side3;
		}
		else return false;
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
		if(side1+side2>=side3&&side2+side3>=side1&&side1+side3>=side2&&side1+side2+side3!=0)
		{
			return side1==side2||side1==side3||side2==side3;
		}
		else return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
		if(side1+side2>=side3&&side2+side3>=side1&&side1+side3>=side2&&side1+side2+side3!=0)
		{
			return side1==side2 && side1==side3 && side2==side3;
		}
		else return false;
        
    }
}