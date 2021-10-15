using ValidatorLib;
using ValidatorLib.Validators;
using Xunit;

namespace UnitTests
{
    public class CustomValidatorTests
    {
        [Theory]
        [InlineData("Asdasd123@", true)]
        [InlineData("czxnmas1#", false)]
        [InlineData("!@#$%^a2", false)]
        [InlineData("njkadsNmvcx", false)]
        [InlineData("As1!", false)]
        [InlineData("NMNMNMNMn1!", true)]
        [InlineData("bnmzxbjh#12", false)]
        [InlineData("*&*&*&*aS1!", true)]
        public void CustomValidatorPasswordIsValid_WhenCalled_ShouldReturnExceptionIfIsNotValid(string password, bool valid)
        {
            var passwordValidator = new CustomValidator<string>();
            passwordValidator.AddRule(x => Validator.Validate(x).MinLength(8));
            passwordValidator.AddRule(x => Validator.Validate(x).Contains(StringValidator.CharType.SmallLetters));
            passwordValidator.AddRule(x => Validator.Validate(x).Contains(StringValidator.CharType.BigLetters));
            passwordValidator.AddRule(x => Validator.Validate(x).Contains(StringValidator.CharType.Alphanumerical));
            passwordValidator.AddRule(x => Validator.Validate(x).Contains(StringValidator.CharType.Numbers));

            var exception = Record.Exception(() => passwordValidator.Validate(password));

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }
    }
}
