using System;

class PriceChangeAlert
{
    // Debugging and Code fixing - Task #3 Version 1.01
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double significanceThreshold = double.Parse(Console.ReadLine());

        double priceToChange = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());

            double difference = CalculateDifference(priceToChange, nextPrice);

            bool isSignificantDifference = HasDifference(difference, significanceThreshold);

            double formattedDifference = difference * 100;

            string message = GetPriceAlterationMessage(nextPrice, priceToChange, formattedDifference, isSignificantDifference);

            Console.WriteLine(message);

            priceToChange = nextPrice;
        }
    }

    private static string GetPriceAlterationMessage(double currentPrice, double price, double difference, bool isSigniticantDifference)
    {
        string priceAlterationMessage = "";

        if (!isSigniticantDifference)
        {
            priceAlterationMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, currentPrice, difference);
        }
        else if (isSigniticantDifference && (difference > 0))
        {
            priceAlterationMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, currentPrice, difference);
        }
        else if (isSigniticantDifference && (difference < 0))
        {
            priceAlterationMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, currentPrice, difference);
        }
        else
        {
            priceAlterationMessage = string.Format("NO CHANGE: {0}", currentPrice);
        }

        return priceAlterationMessage;
    }


    private static bool HasDifference(double threshold, double difference)
    {
        if (Math.Abs(threshold) >= difference)
        {
            return true;
        }

        return false;
    }

    private static double CalculateDifference(double price, double currentPrice)
    {
        double result = (currentPrice - price) / price;
        return result;
    }
}
