using System;
using ValidatorLib;
using Xunit;

namespace UnitTests
{
    public class GuidValidatorTests
    {
        [Fact]
        public void IsGuidEmpty_WhenCalled_ShouldReturnExceptionIfGuidIsNotEmpty()
        {
            var exception = Record.Exception(() => Validator.Validate(default(Guid)).IsEmpty());
            Assert.Null(exception);
        }

        [Fact]
        public void IsNotGuidEmpty_WhenCalled_ShouldReturnExceptionIfGuidIsEmpty()
        {
            var exception = Record.Exception(() => Validator.Validate(Guid.NewGuid()).IsNotEmpty());
            Assert.Null(exception);
        }
    }
}
