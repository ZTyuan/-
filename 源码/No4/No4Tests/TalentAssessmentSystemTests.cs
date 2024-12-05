using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TalentAssessmentSystemTests
    {
        [TestMethod()]
        public void TestFindMedianTalentIndex()
        {
            Assert.AreEqual(8, TalentAssessmentSystem.FindMedianTalentIndex(new int[] { 1, 3, 7, 9, 11 }, new int[] { 2, 4, 8, 10, 12, 14 }));
        }
         [TestMethod()]
    public void TestFindMedianTalentIndex_BothArraysNotEmpty()
    {
        int[] fireAbility = {1, 3, 7, 9, 11};
        int[] iceAbility = {2, 4, 8, 10, 12, 14};
        double median = TalentAssessmentSystem.FindMedianTalentIndex(fireAbility, iceAbility);
        Assert.AreEqual(8, median);
    }

    [TestMethod()]
    public void TestFindMedianTalentIndex_OneArrayEmpty()
    {
        int[] fireAbility = {};
        int[] iceAbility = {2, 4, 8, 10, 12, 14};
        double median = TalentAssessmentSystem.FindMedianTalentIndex(fireAbility, iceAbility);
        Assert.AreEqual(9, median);
    }

    [TestMethod()]
    public void TestFindMedianTalentIndex_OddTotalLength()
    {
        int[] fireAbility = {1, 3, 7};
        int[] iceAbility = {2, 4, 8, 10, 12};
        double median = TalentAssessmentSystem.FindMedianTalentIndex(fireAbility, iceAbility);
        Assert.AreEqual(5.5, median);
    }

    [TestMethod()]
    public void TestFindMedianTalentIndex_EvenTotalLength()
    {
        int[] fireAbility = {1, 3, 7, 9};
        int[] iceAbility = {2, 4, 8, 10, 12};
        double median = TalentAssessmentSystem.FindMedianTalentIndex(fireAbility, iceAbility);
        Assert.AreEqual(7, median);
    }

    [TestMethod()]
    public void TestFindMedianTalentIndex_ElementsOverlap()
    {
        int[] fireAbility = {1, 3, 7, 9, 11};
        int[] iceAbility = {7, 9, 11, 12, 14};
        double median = TalentAssessmentSystem.FindMedianTalentIndex(fireAbility, iceAbility);
        Assert.AreEqual(9, median);
    }

    [TestMethod()]
    public void TestFindMedianTalentIndex_SameElements()
    {
        int[] fireAbility = {1, 2, 3};
        int[] iceAbility = {1, 2, 3};
        double median = TalentAssessmentSystem.FindMedianTalentIndex(fireAbility, iceAbility);
        Assert.AreEqual(2, median);
    }
    }
}