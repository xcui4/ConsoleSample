namespace postage_calculator.Item
{
    public interface IPostCompany
    {
        double GetBookPrice(double weight);
        double GetFoodPrice(double weight);
        double GetOvenPrice(int count);
    }

    public class SF : IPostCompany
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