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
            Assert.AreEqual(0, numero);
        }

        [TestMethod]
        public void TestFibonacci2()
        {
            int numero = Fibonacci.Program.serieFibonacci(1);
            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void TestFibonacci3()
        {
            int numero = Fibonacci.Program.serieFibonacci(2);
            Assert.AreEqual(1, numero);
        }

        [TestMethod]
        public void TestFibonacci4()
        {
            int numero = Fibonacci.Program.serieFibonacci(3);
            Assert.AreEqual(2, numero);
        }

        [TestMethod]
        public void TestFibonacci5()
        {
            int numero = Fibonacci.Program.serieFibonacci(100000);
            Assert.AreEqual(873876091, numero);
        }
    }
}
