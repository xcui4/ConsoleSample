using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using postage_calculator;
using postage_calculator.Item;

namespace postage_calculator_test
{
    [TestClass]
    public class PostageCalculatorTest
    {
        private SF _sf = null;
        [TestInitialize]
        public  void TestInitialize()
        {
            _sf = new SF();
        }
        [TestMethod]
        public void should_caculate_postage_for_book()
        {
            var book = new Book(3, _sf);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> {book});
            Assert.AreEqual(9, postage);
        }

        [TestMethod]
        public void should_caculate_postage_for_food()
        {
            var food = new Food(4, _sf);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> {food});
            Assert.AreEqual(16, postage);
        }

        [TestMethod]
        public void should_caculate_postage_for_oven()
        {
            var oven = new Oven(2, _sf);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> {oven});
            Assert.AreEqual(80, postage);
        }

    }

}
