using Xunit;
using System;

using P03MyTestDemos.App;

namespace P03.MyTestDemos.Tests
{
    public class Calculator_Test
    {
        [Fact]
        public void Sum_Should_Return_Correct_Result_With_Two_Numbers()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(1, 2);

            Assert.Equal(3, result);
        }
        
        [Fact]
        public void Sum_Should_Return_Correct_Result_With_Many_Numbers()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(1, 2, 3, 4, 5, 6);

            Assert.Equal(21, result);
        }

        [Fact]
        public void Sum_Should_Return_Correct_Result_With_No_Numbers()
        {
            var calculator = new Calculator();

            var result = calculator.Sum();

            Assert.Equal(0, result);
        }

        [Fact]
        public void ProductShouldReturnCorrectResultWithTwoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.Product(2, 3);

            Assert.Equal(6, result);
        }
    }
}
