using System;
static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance)
		{
				case<0:
				{
					return 3.213f;
				}
				case <1000 when balance>= 0:
				{
					return 0.5f;
				}
				case>=1000 when balance<5000:
				{
					return 1.621f;
				}
				case>=5000:
				{
					return 2.475f;
				}
				default:
				{
					return 0;
				}
				
		}
    }
    public static decimal Interest(decimal balance)
    {
        switch (balance)
		{
				case<0:
				{
					return 0.03213m*balance;
				}
				case <1000 when balance>= 0:
				{
					return 0.005m*balance;
				}
				case>=1000 when balance<5000:
				{
					return 0.01621m*balance;
				}
				case>=5000:
				{
					return 0.02475m*balance;
				}
				default:
				{
					return 0;
				}
				
		}
    }
    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        switch (balance)
		{
				case<0:
				{
					return 0.03213m*balance+balance;
				}
				case <1000 when balance>= 0:
				{
					return 0.005m*balance+balance;
				}
				case>=1000 when balance<5000:
				{
					return 0.01621m*balance+balance;
				}
				case>=5000:
				{
					return 0.02475m*balance+balance;
				}
				default:
				{
					return 0;
				}
				
		}
    }
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance<targetBalance)
		{
			switch (balance)
			{
				case<0:
				{
					balance= 0.03213m*balance+balance;
					break;
				}
				case <1000 when balance>= 0:
				{
					balance= 0.005m*balance+balance;
					break;
				}
				case>=1000 when balance<5000:
				{
					balance= 0.01621m*balance+balance;
					break;
				}
				case>=5000:
				{
					balance= 0.02475m*balance+balance;
					break;
				}
				default:
				{
					balance= 0;
					break;
				}
				
			}
			
			years++;
		}
		return years;
    }
}
