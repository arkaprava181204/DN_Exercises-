using System;

class FinancialForecast
{
    static double CalculateFutureValue(double currentValue, double growthRate, int years)
    {
       
        if (years == 0)
            return currentValue;

        
        return CalculateFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter current value: ");
        double currentValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual growth rate (in %): ");
        double growthRate = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        double futureValue = CalculateFutureValue(currentValue, growthRate, years);

        Console.WriteLine($"\nFuture Value after {years} years = {futureValue:F2}");
    }
}