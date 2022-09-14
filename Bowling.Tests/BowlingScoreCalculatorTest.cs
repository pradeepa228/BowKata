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
        public void Calculate_Sum_Of_KnowdownPins_Should_return_30()
        {
            string inputString = "22 22 22 22 22 22 22 22 22 22";
            int expectedResult = 40;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }

        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_90()
        {
            string inputString = "9- 9- 9- 9- 9- 9- 9- 9- 9- 9-";
            int expectedResult = 90;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }

        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_43()
        {
            string inputString = "8/ 81 11 11 11 11 11 11 11 11";
            int expectedResult = 43;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }


        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_52()
        {
            string inputString = "8/ 81 11 11 5/ 11 11 11 11 11";
            int expectedResult = 52;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }

        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_61()
        {
            string inputString = "51 X 32 32 32 32 32 32 32 32";
            int expectedResult = 61;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }


        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_71()
        {
            string inputString = "51 X 32 32 X 32 32 32 32 32";
            int expectedResult = 71;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }


        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_81()
        {
            string inputString = "51 X 32 32 X 32 32 32 32 3/ 5";
            int expectedResult = 81;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }

        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_83()
        {
            string inputString = "51 X 32 32 X 32 32 32 32 X 52";
            int expectedResult = 83;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }
        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_78()
        {
            string inputString = "X X 23 45 12 12 23 43 21 33";
            int expectedResult = 78;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }
        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_252()
        {
            string inputString = "X X X X X X X X X 23";
            int expectedResult = 252;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }
        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_127()
        {
            string inputString = "X X X 23 23 23 23 23 23 X X X";
            int expectedResult = 127;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }
        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_300()
        {
            string inputString = "X X X X X X X X X X X X";
            int expectedResult = 300;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }
        /*
        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_150()
        {
            string inputString = "5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5";
            int expectedResult = 150;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }*/
        /*
        [Test]
        public void Calculate_Sum_Of_KnowdownPins_Should_return_300()
        {
            string inputString = "X X X X X X X X X X";
            int expectedResult = 300;
            _bowlingScoreCalculator.calculate_total(inputString).Should().Be(expectedResult);
        }*/
    }
    }
