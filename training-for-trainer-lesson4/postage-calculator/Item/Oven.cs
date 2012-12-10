namespace postage_calculator.Item
{
    public class Oven : IPostable
    {
        public int Count { get; private set; }
        private readonly IPostCompany PostCompany;

        public Oven(int count, IPostCompany postCompany)
        {
            Count = count;
            PostCompany = postCompany;
        }

        public double Postage()
        {
            return PostCompany.GetOvenPrice(Count);
        }

    }
}


