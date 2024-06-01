using FinalProject;
using System;
using Xunit;

namespace TestFinalProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void SumTest(int One, int Two, int res)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Sum(One, Two);

            Assert.Equal(res, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        public void MultiplyTest(int One, int Two, int res)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Multiply(One, Two);

            Assert.Equal(res, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 5, 5)]
        public void DecreaseTest(int One, int Two, int res)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Decrease(One, Two);

            Assert.Equal(res, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(15, 3, 5)]
        public void SplitTest(int One, int Two, int res)
        {
            Calculadora calc = new Calculadora();

            int result = calc.Split(One, Two);

            Assert.Equal(res, result);
        }

        [Fact]
        public void TestSplitWithZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<ArgumentException>(
                () => calc.Split(3, 0));
        }

        [Fact]
        public void TestHistory()
        {
            Calculadora calc = new Calculadora();

            calc.Sum(1, 2);
            calc.Sum(3, 4);
            calc.Sum(5, 6);
            calc.Sum(7, 8);

            var list = calc.History();

            Assert.NotEmpty(list);
            Assert.Equal(4, list.Count);
        }
    }
}
