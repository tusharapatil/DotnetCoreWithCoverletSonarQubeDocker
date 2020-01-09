using Calculations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculationTestsPII
{
    [Trait("Category","Dev")]
    public class CalculationTestPII
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 1, 10)]
        [InlineData(100, 55, 5500)]
        public void Multiplication(decimal x, decimal y, decimal result)
        {
            var calculation = new Multiply(x, y);
            var actual = calculation.Calculate();
            Assert.Equal<decimal>(result, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 1, 10)]
        [InlineData(100, 20, 5)]
        [InlineData(100, 0, 0, false)]
        public void Division(decimal x, decimal y, decimal result, bool succeeds = true)
        {
            var calculation = new Divide(x, y);
            if (succeeds)
            {
                var actual = calculation.Calculate();
                Assert.Equal<decimal>(result, actual);
            }
            else
                Assert.Throws<DivideByZeroException>(() => calculation.Calculate());
        }
    }
}
