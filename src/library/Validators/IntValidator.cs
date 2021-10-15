using System;
using ValidatorLib.Extensions;

namespace ValidatorLib.Validators
{
    /// <summary>
    /// Validation methods
    /// </summary>
    public class IntValidator
    {
        /// <summary>
        /// Object to be checked 
        /// </summary>
        private static int _objToValidate;

        /// <summary>
        /// Assign the object to be checked to a variable
        /// </summary>
        /// <param name="obj">Object to be checked</param>
        public IntValidator(int obj) =>
            _objToValidate = obj;

        /// <summary>
        /// Check if the number is positive
        /// </summary>
        /// <exception cref="ArgumentException">Number is negative</exception>
        public IntValidator IsPositive()
        {
            if (!_objToValidate.IsPositive())
                throw new ArgumentException("The specified int is not positive");

            return this;
        }

        /// <summary>
        ///  Check if the number is negative
        /// </summary>
        /// <exception cref="ArgumentException">Number is positive</exception>
        public IntValidator IsNegative()
        {
            if (!_objToValidate.IsNegative())
                throw new ArgumentException("The specified int is not negative");

            return this;
        }
    }
}
