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
        [TestMethod]
        public void TestSub()
        {
            //Arrange
            var calc = new Core.Calc();
            var Sub = 10;
            //act   
            var result = calc.Sub(new[] { 13, 1, 2 });
            //Assent
            Assert.AreEqual(Sub, result);
        }
        [TestMethod]
        public void TestPow()
        {
            //Arrange
            var calc = new Core.Calc();
            var Sub = 64;
            //act   
            var result = calc.Pow(new[] { 2, 3, 2 });
            //Assent
            Assert.AreEqual(Sub, result);
        }
        [TestMethod]
        public void TestMulti()
        {
            //Arrange
            var calc = new Core.Calc();
            var Sub = 60;
            //act   
            var result = calc.Multi(new[] { 5,4,3 });
            //Assent
            Assert.AreEqual(Sub, result);
        }
    }
}
