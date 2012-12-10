namespace postage_calculator.Item
{
    public class Oven : IPostable
    {
        public int Count { get; private set; }
        public IPostCompany Sf { get; set; }

        public Oven(int count, IPostCompany sf)
        {
            Count = count;
            Sf = sf;
        }

        public double Postage()
        {
            return Sf.GetOvenPrice(Count);
        }

    }
}


