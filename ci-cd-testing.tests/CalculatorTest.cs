using ci_cd_testing.library;

namespace ci_cd_testing.tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Three_Add_Two_Equals_Three()
        {
            var calculator = new Calculator();
            int sum = calculator.Add(3, 2);

            Assert.Equal(5, sum);
        }

        [Fact]
        public void Three_Minus_Two_Equals_One()
        {
            var calculator = new Calculator();
            int difference = calculator.Subtract(3, 2);

            Assert.Equal(1, difference);
        }

        [Fact]
        public void Three_Multiply_Two_Equals_Six()
        {
            var calculator = new Calculator();
            int result = calculator.Multiply(3, 2);

            Assert.Equal(6, result);
        }

        [Fact]
        public void Three_Divide_Three_Equals_One()
        {
            var calculator = new Calculator();
            int result = calculator.Divide(3, 3);

            Assert.Equal(1, result);
        }
    }
}
