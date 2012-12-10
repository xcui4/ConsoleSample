using postage_calculator.Item;

namespace postage_calculator_test
{
    public class ZT : IPostCompany
    {
        public double GetBookPrice(double weight)
        {
            return 0;
        }

        public double GetFoodPrice(double weight)
        {
            return 0;
        }

        public double GetOvenPrice(int count)
        {
            return 0;
        }
    }
}