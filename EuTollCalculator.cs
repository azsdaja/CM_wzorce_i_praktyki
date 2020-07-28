namespace Wzorce2
{
    public class EuTollCalculator : CountryTollCalculator
    {
        public override decimal CalculateToll(Package package)
        {
            return 0;
        }
    }
}