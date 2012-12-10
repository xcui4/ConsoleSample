using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using postage_calculator;
using postage_calculator.Item;

namespace postage_calculator_test
{
    [TestClass]
    public class PostageCalculatorTest
    {
        private IPostCompany m_Sf = null;
        private IPostCompany m_Zt = null;

        [TestInitialize]
        public  void TestInitialize()
        {
            m_Sf = new SF();
            m_Zt = new ZT();
        }

        [TestMethod]
        public void should_caculate_SF_postage_for_book()
        {
            var book = new Book(3);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { book }, m_Sf);
            Assert.AreEqual(9, postage);
        }

        [TestMethod]
        public void should_caculate_SF_postage_for_food()
        {
            var food = new Food(4);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { food }, m_Sf);
            Assert.AreEqual(16, postage);
        }

        [TestMethod]
        public void should_caculate_SF_postage_for_oven()
        {
            var oven = new Oven(2);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { oven }, m_Sf);
            Assert.AreEqual(80, postage);
        }

        [TestMethod]
        public void should_caculate_ZT_postage_for_book_Less_Than_5KG()
        {
            var book = new Book(3);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { book }, m_Zt);
            Assert.AreEqual(10, postage);
        }

        [TestMethod]
        public void should_caculate_ZT_postage_for_book_More_Than_5KG()
        {
            var book = new Book(7);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { book }, m_Zt);
            Assert.AreEqual(18, postage);
        }

        [TestMethod]
        public void should_caculate_ZT_postage_for_Food_Less_Than_5KG()
        {
            var food = new Food(3);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { food }, m_Zt);
            Assert.AreEqual(10, postage);
        }

        [TestMethod]
        public void should_caculate_ZT_postage_for_Food_More_Than_5KG()
        {
            var food = new Food(7);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { food }, m_Zt);
            Assert.AreEqual(18, postage);
        }

        [TestMethod]
        public void should_caculate_ZF_postage_for_oven()
        {
            var oven = new Oven(1);
            var postage = new PostageCalculator().GetPostage(new List<IPostable> { oven }, m_Zt);
            Assert.AreEqual(30, postage);
        }
    }
}
