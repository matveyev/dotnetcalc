using System;
using Xunit;

using DotnetCalc;

namespace DotnetCalc.Test
{
    public class DoubleCalcTest
    {
        private readonly ICalculator<double> calc;
        public DoubleCalcTest() {
            calc = new DoubleCalculator();
        }

        [Fact]
        public void TestAddition()
        {
            Assert.Equal(4.0, calc.Add(1.5, 2.5));
        }

        [Fact]
        public void TestSubtraction()
        {
            Assert.Equal(2.0, calc.Subtract(2.5, 0.5));
        }

        [Fact]
        public void TestMultiplacation()
        {
            Assert.Equal(4.5, calc.Multiply(1.5, 3));
        }

        [Fact]
        public void TestDivision()
        {
            Assert.Equal(4.0, calc.Divide(8.0, 2.0));
        }

        [Fact]
        public void TestOperandToString()
        {
            Assert.Equal("10", calc.OperandValueToString(10.0));
        }

        [Fact]
        public void TestStringToOperandType()
        {
            Assert.Equal(10.0, calc.GetOperandValueFromString("10"));
        }

    }
}
