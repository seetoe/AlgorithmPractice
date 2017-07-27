using System;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class MathTests
    {
        [Fact]
        public void GreatestCommonDenominatorTest()
        {
            int gcd = Algorithm.GreatestCommonDenominator(9, 6);
            Assert.Equal(gcd, 3);
		}

        [Fact]
        public void IsPowerTest() {
            Assert.True(Algorithm.IsPower(4));
        }

        [Fact]
        public void PrimeSumTest() {
            List<int> primeNumbers = Algorithm.PrimeSum(4);
            Assert.Equal(primeNumbers, new List<int> { 2, 2 });
        }
    }
}
