using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace UnitTestProject1
{
    /// <summary>
    /// Test class used to test class
    /// </summary>
    [TestClass]
    public class PassingCarTests
    {
        /// <summary>
        /// Tests if array is not null
        /// </summary>
        [TestMethod]
        public void IsNotNullTest()
        {
            int[] array = { 0, 1, 0, 1, 1 };
            Assert.IsNotNull(array);
        }

        /// <summary>
        /// Tests if first array is equal 0
        /// </summary>
        [TestMethod]
        public void AreEqualTest()
        {
            int[] array = { 0, 1, 0, 1, 1 };
            Assert.AreEqual(array[0], 0);
        }

        /// <summary>
        /// Tests if method returns value 5
        /// </summary>
        [TestMethod]
        public void PassingCarsTest()
        {
            Program.PassingCars();
            Assert.AreEqual(Program.PassingCars(), 5);
        }
    }
}
