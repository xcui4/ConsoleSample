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
            return 0;
        }

        public double GetOvenPrice(int count)
        {
            return 0;
        }

        private double CalculatePrice(double weight)
        {
            return (weight - 5) > 0 ? (weight - 5)*4 + 10 : 10;
        }
    }
}