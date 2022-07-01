using MyTestSite.Services;
using System;
using Xunit;
using Xunit;

namespace TestProject
{
    public class CalculatorControllerTest
    {
        private CalculaterService _testUnit = null;

        public CalculatorControllerTest()
        {
            if (_testUnit == null)
            {
                _testUnit = new CalculaterService();
            }
        }

        [Fact]
        public void Add()
        {
            double a = 10;
            double b = 3;
            double expected = 13;
            var actual = _testUnit.Add(a, b);
            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Substract()
        {
            double x1 = 15;
            double x2 = 8;
            double expected = 7;
            var actual = _testUnit.Subt(x1, x2);
            Assert.Equal(expected, actual, 0);
        }

       
        [Theory(DisplayName = "Divide with paramiters")]
        [InlineData(50, 10, 5)]
        public void Divide(double value1, double value2, double value3)
        {
            //arrang (arangere)
            double x1 = value1;
            double x2 = value2;
            double expected = value3;

            //act (handling)
            var actual = _testUnit.Divi(x1, x2);

            //assert (hævde)
            Assert.Equal(expected, actual, 0);
        }

        [Fact(Skip ="Skip It")]
        public void Multiply()
        {
            double x1 = 10;
            double x2 = 5;
            double expected = 50;
            var actual = _testUnit.Multi(x1, x2);
            Assert.Equal(expected, actual, 0);
        }

        [Fact(DisplayName = "Divide by zero Exception")]
        public void DivideByZeroExeption()
        {
            double x1 = 10;
            double x2 = 0;
            
            Action act = () => _testUnit.Divi(x1, x2);
            Assert.Throws<DivideByZeroException>(act);
        }
    }
}