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
            var engineer = new Employee(0, 3000, 0, 0);
            Assert.AreEqual(3000, engineer.Payment());
        }
        
        [TestMethod]
        public void ShouldGetSalesmanPaymentWithCommission()
        {
            var salesman = new Employee(1, 3000, 100, 0);
            Assert.AreEqual(3000 + 100, salesman.Payment());
        }
        
        [TestMethod]
        public void ShouldGetManagerPaymentWithBonus()
        {
            var salesman = new Employee(2, 3000, 0, 200);
            Assert.AreEqual(3000 + 200, salesman.Payment());
        }
    }
}
