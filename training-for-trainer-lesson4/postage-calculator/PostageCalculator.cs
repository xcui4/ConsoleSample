using System.Collections.Generic;
using System.Linq;
using postage_calculator.Item;

namespace postage_calculator
{
    public class PostageCalculator
    {
        public double GetPostage(IList<IPostable> items, IPostCompany postCompany)
        {
            return items.Sum(i => i.Postage(postCompany));
        }
    }
}
