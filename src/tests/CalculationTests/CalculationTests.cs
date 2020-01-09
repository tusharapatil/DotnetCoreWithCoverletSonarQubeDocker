using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculationTests
{
    [Trait("Category","Dev")]
    public class CalculationTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(10, 1, 11)]
        [InlineData(100, 1, 101)]
        public void Addition(decimal x, decimal y, decimal result)
        {
            var calculation = new Addition(x, y);
            var actual = calculation.Calculate();
            Assert.Equal<decimal>(result, actual);

        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(10, 1, 9)]
        [InlineData(100, 1, 99)]
        public void Subtraction(decimal x, decimal y, decimal result)
        {
            var calculation = new Subtract(x, y);
            var actual = calculation.Calculate();
            Assert.Equal<decimal>(result, actual);

        }

       
    }
    }
