using System.Transactions;

namespace TestProject.Services
{
    public class ConverterService
    {
        public double lengthConverter(double length)
        {
             return length * 100;
        }

        public double temperatureConverter(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

        public double weightConverter(double weight)
        {
            return (weight * 2.205);
        }
    }
}