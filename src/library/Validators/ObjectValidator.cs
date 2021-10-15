using System;
using ValidatorLib.Extensions;

namespace ValidatorLib.Validators
{
    /// <summary>
    /// Validation methods
    /// </summary>
    public class ObjectValidator
    {
        /// <summary>
        /// Object to be checked 
        /// </summary>
        private static object _objToValidate;

        /// <summary>
        /// Assign the object to be checked to a variable
        /// </summary>
        /// <param name="obj">Object to be checked</param>
        public ObjectValidator(object obj) =>
            _objToValidate = obj;

        /// <summary>
        /// Check if the object is null
        /// </summary>
        /// <exception cref="ArgumentException">Object is not null</exception>
        public ObjectValidator IsNull()
        {
            if (_objToValidate.IsNotNull())
                throw new ArgumentException("The specified object is not null");

            return this;
        }

        /// <summary>
        /// Check if the object is not null
        /// </summary>
        /// <exception cref="ArgumentNullException">Object is null</exception>
        public ObjectValidator IsNotNull()
        {
            if (_objToValidate.IsNull())
                throw new ArgumentNullException();

            return this;
        }
    }
}
