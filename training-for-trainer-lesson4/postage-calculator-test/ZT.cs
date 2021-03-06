using postage_calculator.Item;

namespace postage_calculator_test
{
    public class ZT : IPostCompany
    {
        public double GetBookPrice(double weight)
        {
            return CalculatePrice(weight);
        }

        public double GetFoodPrice(double weight)
        {
            return CalculatePrice(weight);

        }

        public double GetOvenPrice(int count)
        {
            return CalculatePrice(count*10);
        }

        private double CalculatePrice(double weight)
        {
            return (weight - 5) > 0 ? (weight - 5)*4 + 10 : 10;
        }
    }
}