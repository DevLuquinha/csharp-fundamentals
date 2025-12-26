namespace Course
{
    internal class HourContract
    {
        public DateTime Date { get; }
        public double ValuePerHour { get; }
        public int Hours { get; }

        public HourContract(
            DateTime date, 
            double valuePerHour,
            int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() => Hours * ValuePerHour;
    }
}
