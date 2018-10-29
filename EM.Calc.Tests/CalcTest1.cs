using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EM.Calc.Tests
{
    [TestClass]
    public class CalcTest1
    {
        [TestMethod]
        public void TestSum()
        {
            //Arrange
            var calc = new Core.Calc();
            var Sum = 10;
            //act   
            var result = calc.Sum(new[] { 5, 3, 2 });
            //Assent
            Assert.AreEqual(Sum, result);
        }
    }
}
