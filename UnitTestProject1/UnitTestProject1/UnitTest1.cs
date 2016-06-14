using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsNotNullTest()
        {
            int[] array = { 0, 1, 0, 1, 1 };
            Assert.IsNotNull(array);
        }

        [TestMethod]
        public void AreEqualTest()
        {
            int[] array = { 0, 1, 0, 1, 1 };
            Assert.AreEqual(array[0], 0);
        }
    }
}
