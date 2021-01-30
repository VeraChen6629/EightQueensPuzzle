using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EightQueensPuzzle.Test
{
    [TestClass]
    public class QueensSolutionCheckerTest
    {
        private QueensSolutionChecker _qsChecker;

        [TestMethod]
        public void TotalNQueensTest()
        {
            _qsChecker = new QueensSolutionChecker();
            Assert.AreEqual(1, _qsChecker.GetQueensSolutions(1,false));
            Assert.AreEqual(0, _qsChecker.GetQueensSolutions(2,false));
            Assert.AreEqual(0, _qsChecker.GetQueensSolutions(3,false));
            Assert.AreEqual(2, _qsChecker.GetQueensSolutions(4,false));
            Assert.AreEqual(10, _qsChecker.GetQueensSolutions(5,false));
            Assert.AreEqual(4, _qsChecker.GetQueensSolutions(6,false));
            Assert.AreEqual(40, _qsChecker.GetQueensSolutions(7,false));
            Assert.AreEqual(92, _qsChecker.GetQueensSolutions(8,false));
            Assert.AreEqual(352, _qsChecker.GetQueensSolutions(9,false));
            Assert.AreEqual(724, _qsChecker.GetQueensSolutions(10, false));
            Assert.AreEqual(2680, _qsChecker.GetQueensSolutions(11, false));
            Assert.AreEqual(14200, _qsChecker.GetQueensSolutions(12, false));

        }
    }
}
