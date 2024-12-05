using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TreasureHuntSystemTests
    {
        [TestMethod()]
        public void TestMaxTreasureValue()
        {
            // 测试空数组
            Assert.AreEqual(0, TreasureHuntSystem.MaxTreasureValue(null));
            // 测试只有一个宝箱的情况
            Assert.AreEqual(3, TreasureHuntSystem.MaxTreasureValue(new int[] { 3 }));
            // 测试示例
            Assert.AreEqual(12, TreasureHuntSystem.MaxTreasureValue(new int[] { 3, 1, 5, 2, 4 }));
            // 测试两个宝箱的情况
            Assert.AreEqual(5, TreasureHuntSystem.MaxTreasureValue(new int[] { 3, 5 }));
            // 测试更多宝箱的情况
            Assert.AreEqual(20, TreasureHuntSystem.MaxTreasureValue(new int[] { 2, 17, 9, 3, 1 }));
            Assert.AreEqual(7, TreasureHuntSystem.MaxTreasureValue(new int[] { 4, 3, 2, 3 }));
        }
    }
}