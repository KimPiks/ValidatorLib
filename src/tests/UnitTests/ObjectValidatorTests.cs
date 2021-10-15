using ValidatorLib;
using Xunit;

namespace UnitTests
{
    public class ObjectValidatorTests
    {
        [Fact]
        public void IsNull_WhenCalled_ShouldReturnExceptionIfIsNotNull()
        {
            var exception = Record.Exception(() => Validator.Validate((object)null).IsNull());
            Assert.Null(exception);
        }

        [Fact]
        public void IsNotNull_WhenCalled_ShouldReturnExceptionIfIsNull()
        {
            var exception = Record.Exception(() => Validator.Validate(new object()).IsNotNull());
            Assert.Null(exception);
        }
    }
}
