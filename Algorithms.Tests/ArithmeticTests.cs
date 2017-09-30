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
			Assert.False(Algorithm.IsPower(11));
            Assert.True(Algorithm.IsPower(4));
            Assert.True(Algorithm.IsPower(243));
        }

        [Fact]
        public void PrimeSumTest() {
            List<int> primeNumbers = Algorithm.PrimeSum(4);
            Assert.Equal(primeNumbers, new List<int> { 2, 2 });
        }

        [Fact]
        public void JumpWallsTest() {
            int[] wallHeights = new int[] { 11, 11 };
            int x = 10;
            int y = 1;
            int numberOfJumps = Arithmetic.JumpWalls.NumberOfJumps(wallHeights, x, y);
            Assert.Equal(numberOfJumps, 4);

			wallHeights = new int[] { 11, 10, 10, 9 };
			x = 10;
			y = 1;
			numberOfJumps = Arithmetic.JumpWalls.NumberOfJumps(wallHeights, x, y);
			Assert.Equal(numberOfJumps, 5);
        }

        [Fact]
        public void CircularTourTest() {
            List<Arithmetic.CircularTour.PetrolPump> pumpData = new List<Arithmetic.CircularTour.PetrolPump> {
                new Arithmetic.CircularTour.PetrolPump(4, 6),
                new Arithmetic.CircularTour.PetrolPump(6, 5),
                new Arithmetic.CircularTour.PetrolPump(7, 3),
                new Arithmetic.CircularTour.PetrolPump(4, 5)
            };
            int startingPoint = Arithmetic.CircularTour.FindStartingPoint(4, pumpData);
            Assert.Equal(startingPoint, 1);
        }
    }
}
