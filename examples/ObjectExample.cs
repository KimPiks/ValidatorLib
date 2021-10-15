using System;
using ValidatorLib;

namespace Example
{
    internal class Program
    {
        static void Main()
        {
            var obj = new object();
            try
            {
                Validator.Validate(obj).IsNotNull();
            }
            catch (ArgumentException e)
            {
                // If an exception is thrown, the object is null
            }
        }
    }
}