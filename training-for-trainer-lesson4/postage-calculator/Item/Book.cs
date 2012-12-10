

namespace postage_calculator.Item
{
    public class Book : IPostable
    {
        public double Weight { get; private set; }

        public Book(double weight, SF sf)
        {
            Weight = weight;
        }

        public double Postage()
        {
            return Weight * 3;
        }
    }
}


