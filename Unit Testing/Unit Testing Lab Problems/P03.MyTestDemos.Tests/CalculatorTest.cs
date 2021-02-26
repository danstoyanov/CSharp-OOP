using Xunit;
using System;

using P03MyTestDemos.App;

namespace P03.MyTestDemos.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void SumShouldReturnCorrectResultWithTwoNumbers()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Sum(1, 2);

            Assert.Equal(3, result);
        }
        
        [Fact]
        public void SumShouldReturnCorrectResultWithManyNumbers()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Sum(1, 2, 3, 4, 5, 6);

            Assert.Equal(21, result);

            if (result != 21)
            {
                throw new InvalidOperationException("SumShouldReturnCorrectResultWithTwoNumbers failed !");
            }
        }

        [Fact]
        public void SumShouldReturnCorrectResultWithNoNumbers()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Sum();

            Assert.Equal(0, result);

            if (result != 0)
            {
                throw new InvalidOperationException("SumShouldReturnCorrectResultWithTwoNumbers failed !");
            }
        }
    }
}
