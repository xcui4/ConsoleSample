

namespace postage_calculator.Item
{
    public class Book : IPostable
    {
        public double Weight { get; private set; }

        public Book(double weight)
        {
            Weight = weight;
        }

        public double Postage(IPostCompany postCompany)
        {
            return postCompany.GetBookPrice(Weight);
        }
    }
}


