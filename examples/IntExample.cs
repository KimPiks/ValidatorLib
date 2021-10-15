using System;
using ValidatorLib;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            var num = 5;
            try
            {
                Validator.Validate(num).IsPositive();
            }
            catch (ArgumentException e)
            {
                // If an exception is thrown, the number is negative
            }
        }
    }
}