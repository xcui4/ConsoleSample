namespace postage_calculator.Item
{
    public class Food : IPostable
    {
        public double Weight { get; private set; }

        public Food(double weight)
        {
            Weight = weight;
        }

        public double Postage()
        {
            return Weight * 4;
        }
    }
}


