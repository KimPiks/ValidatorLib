using System;
using ValidatorLib;
using ValidatorLib.Validators;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            var user = new User
            {
                Id = 1,
                Username = "admin",
                Email = "admin@email.com",
                Password = "Password1!"
            };

            var validator = new CustomValidator<User>();

            validator.AddRule(x => Validator.Validate(x.Id).IsPositive());

            validator.AddRule(x => Validator.Validate(x.Username).Only(StringValidator.CharType.SmallLetters));
            validator.AddRule(x => Validator.Validate(x.Username).MinLength(5));

            validator.AddRule(x => Validator.Validate(x.Email).IsEmailAddress());

            validator.AddRule(x => Validator.Validate(x.Password).Contains(StringValidator.CharType.SmallLetters));
            validator.AddRule(x => Validator.Validate(x.Password).Contains(StringValidator.CharType.BigLetters));
            validator.AddRule(x => Validator.Validate(x.Password).Contains(StringValidator.CharType.Numbers));
            validator.AddRule(x => Validator.Validate(x.Password).Contains(StringValidator.CharType.Alphanumerical));
            validator.AddRule(x => Validator.Validate(x.Password).MinLength(8));

            try
            {
                validator.Validate(user);
            }
            catch (ArgumentException e)
            {
                // If an exception is thrown, the user is not valid
            }
        }
    }

    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}