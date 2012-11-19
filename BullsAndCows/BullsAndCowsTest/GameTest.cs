using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BullsAndCowsTest
{
    [TestClass]
    public class GameTest
    {

        [TestMethod]
        public void ShouldReturnTrueGivenCorrectAnswer()
        {
            Assert.IsTrue(BullsAndCows.Program.game("1234", new int[] {1,2,3,4}));
        }

        [TestMethod]
        public void ShouldReturnFalseGivenAnswerLengthLessThanFour()
        {
            Assert.IsFalse(BullsAndCows.Program.game("123", new int[] { 1, 2, 3, 4 }));
        }
        
        [TestMethod]
        public void ShouldReturnFalseGivenAnswerIncludeNumberSmallerThanOne()
        {
            Assert.IsFalse(BullsAndCows.Program.game("1230", new int[] { 1, 2, 3, 4 }));
        }
        
        [TestMethod]
        public void ShouldReturnFalseGivenAnswerIncludeNonNumber()
        {
            Assert.IsFalse(BullsAndCows.Program.game("123a", new int[] { 1, 2, 3, 4 }));
        }
        
        [TestMethod]
        public void ShouldReturnFalseGivenAnswerIncludeCows()
        {
            Assert.IsFalse(BullsAndCows.Program.game("4321", new int[] { 1, 2, 3, 4 }));
        }
    }
}
