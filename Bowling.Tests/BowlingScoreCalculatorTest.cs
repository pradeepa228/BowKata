using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace Bowling.Tests
{
    public class BowlingScoreCalculatorTest
    {
        private BowlingScoreCalculator _bowlingScoreCalculator;
        [SetUp]
        public void Setup()
        {
            _bowlingScoreCalculator = new BowlingScoreCalculator();
        }

        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_Sum()
        {
            string inputString = "12 12 12 12 12 12 12 12 12 12";
            int expectedResult = 30;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }
    }
}
