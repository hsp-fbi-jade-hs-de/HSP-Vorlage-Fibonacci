using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HSP_Vorlage_Fibonacci;

namespace Fibonacci_Unittesting
{
    [TestClass]
    public class FibonacciUnitTests
    {

        [TestMethod]
        public void FibonacciTest1()
        {
            Program prg = new Program();

            var numbers = prg.FibonacciNumbers(20);

            Assert.AreEqual("1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765", numbers);

        }
    }
}
