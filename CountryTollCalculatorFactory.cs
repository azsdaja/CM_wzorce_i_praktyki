using System;

namespace Wzorce2
{
    public class CountryTollCalculatorFactory
    {
        public decimal CalculateToll(Package package)
        {
            CountryTollCalculator calculator;
            
            switch (package.Country)
            {
                case Country.China:
                    calculator = new ChinaTollCalculator();
                    break;
                case Country.Usa:
                    calculator = new UsaTollCalculator();
                    break;
                case Country.Germany:
                case Country.Poland:
                    calculator = new EuTollCalculator();
                    break;
                case Country.Russia:
                    calculator = new RussiaTollCalculator();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(package.Country));
            }

            decimal toll = calculator.CalculateToll(package);
            return toll;
        }
    }
}