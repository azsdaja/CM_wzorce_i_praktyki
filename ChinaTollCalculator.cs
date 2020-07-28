namespace Wzorce2
{
    public class ChinaTollCalculator : CountryTollCalculator
    {
        public override decimal CalculateToll(Package package)
        {
            if (package.Weight < 10)
            {
                return 0.05m * package.Value;
            }

            if (package.Weight < 100)
            {
                return 0.07m * package.Value;
            }

            return 0.1m * package.Value;
        }
    }
}