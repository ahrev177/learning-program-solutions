namespace FinancialForecasting
{
    public static class FinancialForecast
    {
        public static double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return PredictFutureValue(currentValue, growthRate, years - 1) * (1 + growthRate);
        }

        public static double PredictFutureValueIterative(double currentValue, double growthRate, int years)
        {
            for (int i = 0; i < years; i++)
                currentValue *= (1 + growthRate);

            return currentValue;
        }
    }
}