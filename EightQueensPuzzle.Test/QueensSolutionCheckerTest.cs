using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EightQueensPuzzle.Test
{
    [TestClass]
    public class QueensSolutionCheckerTest
    {
        QueensSolutionChecker qsChecker;

        [TestMethod]
        public void TotalNQueensTest()
        {
            qsChecker = new QueensSolutionChecker();
            Assert.AreEqual(1, qsChecker.GetQueensSolutions(1,false));
            Assert.AreEqual(0, qsChecker.GetQueensSolutions(2,false));
            Assert.AreEqual(0, qsChecker.GetQueensSolutions(3,false));
            Assert.AreEqual(2, qsChecker.GetQueensSolutions(4,false));
            Assert.AreEqual(10, qsChecker.GetQueensSolutions(5,false));
            Assert.AreEqual(4, qsChecker.GetQueensSolutions(6,false));
            Assert.AreEqual(40, qsChecker.GetQueensSolutions(7,false));
            Assert.AreEqual(92, qsChecker.GetQueensSolutions(8,false));
            Assert.AreEqual(352, qsChecker.GetQueensSolutions(9,false));
            Assert.AreEqual(724, qsChecker.GetQueensSolutions(10, false));
            Assert.AreEqual(2680, qsChecker.GetQueensSolutions(11, false));
            Assert.AreEqual(14200, qsChecker.GetQueensSolutions(12, false));

        }
    }
}
