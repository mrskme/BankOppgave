using System;
using NUnit.Framework;

namespace BankOO.UnitTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var yearAndMonth = new YearAndMonth(2000, 5);
            Assert.AreEqual(5, yearAndMonth.Month);
            Assert.AreEqual(2000, yearAndMonth.Year);
        }

        [Test]
        public void Test2()
        {
            var date = new DateTime(2000, 12, 24);
            var yearAndMonth = YearAndMonth.GetLatestYearAndMonth(date);
            Assert.AreEqual(11, yearAndMonth.Month);
            Assert.AreEqual(2000, yearAndMonth.Year);
        }

        [Test]
        public void Test3()
        {
            var date = new DateTime(2000, 1, 24);
            var yearAndMonth = YearAndMonth.GetLatestYearAndMonth(date);
            Assert.AreEqual(12, yearAndMonth.Month);
            Assert.AreEqual(1999, yearAndMonth.Year);
        }
    }
}