namespace postage_calculator.Item
{
    public class Food : IPostable
    {
        public double Weight { get; private set; }
        public IPostCompany PostCompany { get; set; }

        public Food(double weight, IPostCompany postCompany)
        {
            Weight = weight;
            PostCompany = postCompany;
        }

        public double Postage()
        {
            return PostCompany.GetFoodPrice(Weight);
        }
    }
}


