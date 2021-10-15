using System;
using ValidatorLib;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            var guid = Guid.NewGuid();
            try
            {
                Validator.Validate(guid).IsNotEmpty();
            }
            catch (ArgumentException e)
            {
                // If an exception is thrown, the guid is empty
            }
        }
    }
}