using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) return 3.213f;
        if (balance < 1000) return 0.5f;
        if (balance < 5000) return 1.621f;
        return 2.475f;
    }

    public static decimal Interest(decimal balance) => (decimal)InterestRate(balance) * balance / 100;

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        var interestRate = InterestRate(balance) / 100;
        var periodRate = (float)Math.Pow(1 + interestRate, 1);
        return balance * (decimal)periodRate;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal newBalance = balance;

        while (newBalance < targetBalance)
        {
            newBalance += (newBalance * ((decimal)InterestRate(newBalance) / 100));
            years++;
        }

        return years;
    }

}
