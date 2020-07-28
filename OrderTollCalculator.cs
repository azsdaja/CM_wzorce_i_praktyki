namespace Wzorce2
{
    public class OrderTollCalculator
    {
        private readonly CountryTollCalculatorFactory _countryTollCalculatorFactory = new CountryTollCalculatorFactory();

        public decimal CalculateToll(Order order)
        {
            decimal sumOfTolls = 0;
            foreach (var package in order.Packages)
            {
                decimal toll = _countryTollCalculatorFactory.CalculateToll(package);
                sumOfTolls += toll;
            }
            return sumOfTolls;
        }
    }
}