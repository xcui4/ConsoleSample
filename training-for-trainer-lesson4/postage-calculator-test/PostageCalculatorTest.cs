using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using postage_calculator;
using postage_calculator.Item;

namespace postage_calculator_test
{
    [TestClass]
    public class PostageCalculatorTest
    {
        private IPostCompany _Sf = null;
        private IPostCompany _Zt = null;

        [TestInitialize]
        public  void TestInitialize()
        {
            _Sf = new SF();
            _Zt = new ZT();
        }

        [TestMethod]
        public void should_caculate_SF_postage_for_book()
        {
            var book = new Book(3, _Sf);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> {book});
            Assert.AreEqual(9, postage);
        }

        [TestMethod]
        public void should_caculate_SF_postage_for_food()
        {
            var food = new Food(4, _Sf);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> {food});
            Assert.AreEqual(16, postage);
        }

        [TestMethod]
        public void should_caculate_SF_postage_for_oven()
        {
            var oven = new Oven(2, _Sf);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> {oven});
            Assert.AreEqual(80, postage);
        }

        [TestMethod]
        public void should_caculate_ZT_postage_for_book_Less_Than_5KG()
        {
            var book = new Book(3, _Zt);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { book });
            Assert.AreEqual(10, postage);
        }

        [TestMethod]
        public void should_caculate_ZT_postage_for_book_More_Than_5KG()
        {
            var book = new Book(7, _Zt);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { book });
            Assert.AreEqual(18, postage);
        }

    }
}
