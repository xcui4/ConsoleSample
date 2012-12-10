namespace postage_calculator.Item
{
    public class Oven : IPostable
    {
        public int Count { get; private set; }

        public Oven(int count)
        {
            Count = count;
        }

        public double Postage()
        {
            return 40 * Count;
        }

    }
}


