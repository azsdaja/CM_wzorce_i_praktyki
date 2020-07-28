namespace Wzorce2
{
    public class RussiaTollCalculator : CountryTollCalculator
    {
        public override decimal CalculateToll(Package package)
        {
            return 0.08m * package.Value;
        }
    }
}