namespace postage_calculator.Item
{
    public class Food : IPostable
    {
        public double Weight { get; private set; }
        public IPostCompany Sf { private get; set; }

        public Food(double weight, IPostCompany sf)
        {
            Weight = weight;
            Sf = sf;
        }

        public double Postage()
        {
            return Sf.GetFoodPrice(Weight);
        }
    }
}


