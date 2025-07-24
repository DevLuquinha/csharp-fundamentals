namespace Course
{
    internal class CurrencyConverter
    {
        private static double IOF = 1.06;
        
        public static double CalculateValue(double dollarValue, double amountDollars)
        {
            return (dollarValue * amountDollars) * IOF;
        }
    }
}
