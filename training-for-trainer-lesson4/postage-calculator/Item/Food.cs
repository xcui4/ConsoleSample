namespace postage_calculator.Item
{
    public class Food : IPostable
    {
        public double Weight { get; private set; }
        public SF Sf { private get; set; }

        public Food(double weight, SF sf)
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


