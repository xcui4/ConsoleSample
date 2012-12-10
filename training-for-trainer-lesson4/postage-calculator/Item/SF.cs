namespace postage_calculator.Item
{
    public class SF
    {
        public double GetBookPrice(double weight)
        {
            return weight * 3;
        }

        public double GetFoodPrice(double weight)
        {
            return weight * 4;
        }

        public double GetOvenPrice(int count)
        {
            return count*40;
        }
    }
}