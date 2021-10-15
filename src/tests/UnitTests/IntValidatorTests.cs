using ValidatorLib;
using Xunit;

namespace UnitTests
{
    public class IntValidatorTests
    {
        [Theory]
        [InlineData(1, true)]
        [InlineData(-1, false)]
        public void IsPositive_WhenCalled_ShouldReturnExceptionIfNumberIsNegative(int num, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(num).IsPositive());

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(-1, true)]
        public void IsNegative_WhenCalled_ShouldReturnExceptionIfNumberIsPositive(int num, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(num).IsNegative());

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }
    }
}
