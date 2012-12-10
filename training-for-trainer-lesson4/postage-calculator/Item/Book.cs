

namespace postage_calculator.Item
{
    public class Book : IPostable
    {
        private readonly IPostCompany PostCompany;
        public double Weight { get; private set; }

        public Book(double weight, IPostCompany postCompany)
        {
            PostCompany = postCompany;
            Weight = weight;
        }

        public double Postage()
        {
            return PostCompany.GetBookPrice(Weight);
        }
    }
}


