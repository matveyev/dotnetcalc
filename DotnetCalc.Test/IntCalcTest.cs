using System;
using Xunit;

using DotnetCalc;

namespace DotnetCalc.Test
{
    public class IntCalcTest
    {
        private readonly ICalculator<int> calc;
        public IntCalcTest() {
            calc = new IntCalculator();
        }

        [Fact]
        public void TestAddition()
        {
            Assert.Equal(4, calc.Add(2, 2));
        }

        [Fact]
        public void TestSubtraction()
        {
            Assert.Equal(8, calc.Subtract(10, 2));
        }

        [Fact]
        public void TestMultiplacation()
        {
            Assert.Equal(10, calc.Multiply(5, 2));
        }

        [Fact]
        public void TestDivision()
        {
            Assert.Equal(4, calc.Divide(8, 2));
        }

        [Fact]
        public void TestOperandToString()
        {
            Assert.Equal("10", calc.OperandValueToString(10));
        }

        [Fact]
        public void TestStringToOperandType()
        {
            Assert.Equal(10, calc.GetOperandValueFromString("10"));
        }
    }
}
