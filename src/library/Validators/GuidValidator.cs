using System;
using ValidatorLib.Extensions;

namespace ValidatorLib.Validators
{
    /// <summary>
    /// Validation methods
    /// </summary>
    public class GuidValidator
    {
        /// <summary>
        /// Object to be checked 
        /// </summary>
        private static Guid _objToValidate;

        /// <summary>
        /// Assign the object to be checked to a variable
        /// </summary>
        /// <param name="obj">Object to be checked</param>
        public GuidValidator(Guid obj) =>
            _objToValidate = obj;

        /// <summary>
        /// Check if the object is empty
        /// </summary>
        /// <exception cref="ArgumentException">Object is not empty</exception>
        public GuidValidator IsEmpty()
        {
            if (!_objToValidate.IsEmpty())
                throw new ArgumentException("The specified Guid is not empty");

            return this;
        }

        /// <summary>
        /// Check if the object is not empty
        /// </summary>
        /// <exception cref="ArgumentException">Object is empty</exception>
        public GuidValidator IsNotEmpty()
        {
            if (_objToValidate.IsEmpty())
                throw new ArgumentException("The specified Guid is empty");

            return this;
        }
    }
}
