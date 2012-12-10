

namespace postage_calculator.Item
{
    public class Book : IPostable
    {
        private readonly SF m_Sf;
        public double Weight { get; private set; }

        public Book(double weight, SF sf)
        {
            m_Sf = sf;
            Weight = weight;
        }

        public double Postage()
        {
            return m_Sf.GetBookPrice(Weight);
        }
    }
}


