using System;
using ValidatorLib;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            var str = "example@email.com";
            try
            {
                Validator.Validate(str).IsEmailAddress();
                Validator.Validate(str).MinLength(8);
                Validator.Validate(str).IsNotEmpty();
            }
            catch (ArgumentException e)
            {
                // If an exception is thrown, the string is not valid
            }
        }
    }
}