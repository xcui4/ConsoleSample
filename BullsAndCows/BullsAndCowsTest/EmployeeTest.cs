using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainingForTrainer;

namespace TrainingForTrainerTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void ShouldGetEngineerPayment()
        {
            var engineer = new Engineer(3000);
            Assert.AreEqual(3000, engineer.Payment());
        }
        
        [TestMethod]
        public void ShouldGetSalesmanPaymentWithCommission()
        {
            var salesman = new Salesman(3000, 100);
            Assert.AreEqual(3000 + 100, salesman.Payment());
        }
        
        [TestMethod]
        public void ShouldGetManagerPaymentWithBonus()
        {
            var manager = new Manager(3000, 200);
            Assert.AreEqual(3000 + 200, manager.Payment());
        }
    }
}
