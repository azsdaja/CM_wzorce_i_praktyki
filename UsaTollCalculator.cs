namespace Wzorce2
{
    public class UsaTollCalculator : CountryTollCalculator
    {
        public override decimal CalculateToll(Package package)
        {
            return 0.05m * package.Value;
        }
    }
}