using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Percentfunctions.Test
{
    [TestFixture]
    public class PercentfunctionsIntegerTests
    {

        /// <summary>
        /// Integer collection containing the elements
        /// null, -1, 2, 5, 6, 7, 7, 8, 9, 10, 11, but in a different order,
        /// Order should not be a factor in percent rank calculation.
        /// </summary>
        protected readonly int?[] integerCollection =
            new int?[]
            {
                8,
                7,
                6,
                7,
                5,
                9,
                null,
                10,
                -1,
                2,
                11
            };

        [SetUp]
        public void SetupPercentileIntegerCollection()
        {
        }

        [TestCase(13, 100d)]
        [TestCase(12, 100d)]
        [TestCase(11, 95d)]
        [TestCase(10, 85d)]
        [TestCase(9, 75d)]
        [TestCase(8, 65d)]
        [TestCase(7, 50d)]
        [TestCase(6, 35d)]
        [TestCase(5, 25d)]
        [TestCase(4, 20d)]
        [TestCase(3, 20d)]
        [TestCase(2, 15d)]
        [TestCase(1, 10d)]
        [TestCase(0, 10d)]
        [TestCase(-1, 5d)]
        [TestCase(-2, 0d)]
        [TestCase(null, null)]
        public void TestIntegerPercentRank(int? elementValue, double? expectedRank)
        {
            Assert.AreEqual(expectedRank, Percentfuntions.Percentrank(elementValue, integerCollection));
        }
    }

    [TestFixture]
    public class PercentfunctionsDoubleTests
    {

        /// <summary>
        /// Integer collection containing the elements
        /// null, -1.5, 2.8, 5.9, 6.1, 7.5, 7.5, 8.0, 9.3, 10.6, 11.7, but in a different order,
        /// Order should not be a factor in percent rank calculation.
        /// </summary>
        protected readonly double?[] doubleCollection =
            new double?[]
            {
                8.0d,
                7.5d,
                6.1d,
                7.5d,
                5.9d,
                9.3d,
                null,
                10.6d,
                -1.5d,
                2.8d,
                11.7d
            };

        [SetUp]
        public void SetupPercentileDoubleCollection()
        {
        }

        [TestCase(13.0, 100d)]
        [TestCase(12.1, 100d)]
        [TestCase(11.8, 100d)]
        [TestCase(11.7, 95d)]
        [TestCase(11.6, 90d)]
        [TestCase(10.6, 85d)]
        [TestCase(10.0, 80d)]
        [TestCase(9.3, 75d)]
        [TestCase(8.0, 65d)]
        [TestCase(7.6, 60d)]
        [TestCase(7.5, 50d)]
        [TestCase(7.4, 40d)]
        [TestCase(6.1, 35d)]
        [TestCase(5.9, 25d)]
        [TestCase(4.0, 20d)]
        [TestCase(3.0, 20d)]
        [TestCase(2.8, 15d)]
        [TestCase(1.0, 10d)]
        [TestCase(0.0, 10d)]
        [TestCase(-1.5, 5d)]
        [TestCase(-2d, 0d)]
        [TestCase(null, null)]
        public void TestDoublePercentRank(int? elementValue, double? expectedRank)
        {
            Assert.AreEqual(expectedRank, Percentfuntions.Percentrank(elementValue, doubleCollection));
        }
    }
}
