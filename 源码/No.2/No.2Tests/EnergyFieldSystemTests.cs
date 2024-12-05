using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    
    public class EnergyFieldSystemTests
    {
        [TestMethod]
        public void TestMaxEnergyField()
        {
            Assert.AreEqual(52.5, EnergyFieldSystem.MaxEnergyField(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        }
        [TestMethod]
        public void TestMaxEnergyField_WithNullInput_ReturnsZero()
        {
            Assert.AreEqual(0, EnergyFieldSystem.MaxEnergyField(null));
        }

        [TestMethod]
        public void TestMaxEnergyField_WithEmptyArray_ReturnsZero()
        {
            Assert.AreEqual(0, EnergyFieldSystem.MaxEnergyField(new int[] { }));
        }

        [TestMethod]
        public void TestMaxEnergyField_WithSingleElement_ReturnsZero()
        {
            Assert.AreEqual(0, EnergyFieldSystem.MaxEnergyField(new int[] { 10 }));
        }

        [TestMethod]
        public void TestMaxEnergyField_WithTwoElements_ReturnsCorrectResult()
        {
            Assert.AreEqual(5, EnergyFieldSystem.MaxEnergyField(new int[] { 3, 7 }));
        }

        [TestMethod]
        public void TestMaxEnergyField_WithAllElementsSameHeight_ReturnsCorrectResult()
        {
            Assert.AreEqual(20, EnergyFieldSystem.MaxEnergyField(new int[] { 5, 5, 5, 5, 5 }));
        }

        [TestMethod]
        public void TestMaxEnergyField_WithLargeArray_ReturnsCorrectResult()
        {
            Assert.AreEqual(10004*3/2.0f, EnergyFieldSystem.MaxEnergyField(new int[] { 3 ,4 ,10000,1, 100, 4 }));
        }
    }
}