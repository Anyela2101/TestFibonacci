using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFibonacci
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibonacci1()
        {
            int numero = Fibonacci.Program.serieFibonacci(0);
            Assert.AreEqual(1, numero);
        }
    }
}
