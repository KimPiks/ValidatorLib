using ValidatorLib;
using ValidatorLib.Validators;
using Xunit;

namespace UnitTests
{
    public class StringValidatorTests
    {
        [Theory]
        [InlineData("test@email.com", true)]
        [InlineData("asd123c@email.x.com", true)]
        [InlineData("asd_zxc@email.x.com", true)]
        [InlineData("testemail.com", false)]
        [InlineData(".test@email.com", false)]
        public void EmailIsValid_WhenCalled_ShouldReturnExceptionIfIsNotValid(string email, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(email).IsEmailAddress());

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }

        [Theory]
        [InlineData("2025550156", true)]
        [InlineData("5823330783", true)]
        [InlineData("971507703868", true)]
        [InlineData("500487119", true)]
        [InlineData("582-333-0783", true)]
        [InlineData("971 5077 03868", true)]
        [InlineData("+48 971 5077 03868", true)]
        [InlineData("500a487119", false)]
        public void IsPhoneNumber_WhenCalled_ShouldReturnExceptionIfIsNotValid(string phoneNumber, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(phoneNumber).IsPhoneNumber());

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }

        [Theory]
        [InlineData("123", 3, true)]
        [InlineData("12345", 3, true)]
        [InlineData("123", 5, false)]
        [InlineData("12345", 6, false)]
        public void MinLength_WhenCalled_ShouldReturnExceptionIfStrIsLongerThanXCharacters(string str, int minLength, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(str).MinLength(minLength));

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }

        [Theory]
        [InlineData("123", 3, true)]
        [InlineData("12345", 3, false)]
        [InlineData("123", 5, true)]
        [InlineData("12345", 6, true)]
        public void MaxLength_WhenCalled_ShouldReturnExceptionIfStrIsShorterThanXCharacters(string str, int maxLength, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(str).MaxLength(maxLength));

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }

        [Theory]
        [InlineData("", true)]
        [InlineData("1", false)]
        public void IsEmpty_WhenCalled_ShouldReturnExceptionIfStrIsNotEmpty(string str, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(str).IsEmpty());

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }

        [Theory]
        [InlineData("", false)]
        [InlineData("1", true)]
        public void IsNotEmpty_WhenCalled_ShouldReturnExceptionIfStrIsEmpty(string str, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(str).IsNotEmpty());

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }

        [Theory]
        [InlineData("dsafa", StringValidator.CharType.SmallLetters, true)]
        [InlineData("dsaFa", StringValidator.CharType.SmallLetters, false)]
        [InlineData("ASDSDA", StringValidator.CharType.BigLetters, true)]
        [InlineData("AsDSDA", StringValidator.CharType.BigLetters, false)]
        [InlineData("129126", StringValidator.CharType.Numbers, true)]
        [InlineData("129a26", StringValidator.CharType.Numbers, false)]
        [InlineData("#@&$%^!", StringValidator.CharType.Alphanumerical, true)]
        [InlineData("#@&$%^1", StringValidator.CharType.Alphanumerical, false)]
        public void Only_WhenCalled_ShouldReturnExceptionIfStrDoesntContainsOnlyCharType(string str, StringValidator.CharType charType, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(str).Only(charType));

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }
        
        [Theory]
        [InlineData("BJHbHJV", StringValidator.CharType.SmallLetters, true)]
        [InlineData("BJHBHJV", StringValidator.CharType.SmallLetters, false)]
        [InlineData("dskjaGhk", StringValidator.CharType.BigLetters, true)]
        [InlineData("dskjaghk", StringValidator.CharType.BigLetters, false)]
        [InlineData("dasi4hfda", StringValidator.CharType.Numbers, true)]
        [InlineData("dasiahfda", StringValidator.CharType.Numbers, false)]
        [InlineData("joif!kfds", StringValidator.CharType.Alphanumerical, true)]
        [InlineData("joif1kfds", StringValidator.CharType.Alphanumerical, false)]
        public void Contains_WhenCalled_ShouldReturnExceptionIfStrDoesntContainsCharType(string str, StringValidator.CharType charType, bool valid)
        {
            var exception = Record.Exception(() => Validator.Validate(str).Contains(charType));

            if (valid)
                Assert.Null(exception);
            else
                Assert.NotNull(exception);
        }
    }
}
