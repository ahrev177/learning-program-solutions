using FinancialForecasting;
using System;

class Program
{
    static void Main()
    {
        double recursive = FinancialForecast.PredictFutureValue(1000, 0.05, 10);
        Console.WriteLine($"Recursive Forecast: ${recursive:F2}");

        double iterative = FinancialForecast.PredictFutureValueIterative(1000, 0.05, 10);
        Console.WriteLine($"Iterative Forecast: ${iterative:F2}");
    }
}