using System;
using ValidatorLib.Extensions;
using ValidatorLib.Validators;

namespace ValidatorLib
{
    /// <summary>
    /// Main functions for validation
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Validation function for Guid type
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <exception cref="ArgumentNullException">Object is null</exception>
        public static GuidValidator Validate(Guid obj)
        {
            if (obj.IsNull())
                throw new ArgumentNullException();

            return new GuidValidator(obj);
        }

        /// <summary>
        /// Validation function for int type
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <exception cref="ArgumentNullException">Object is null</exception>
        public static IntValidator Validate(int obj)
        {
            if (obj.IsNull())
                throw new ArgumentNullException();

            return new IntValidator(obj);
        }

        /// <summary>
        /// Validation function for string type
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <exception cref="ArgumentNullException">Object is null</exception>
        public static StringValidator Validate(string obj)
        {
            if (obj.IsNull())
                throw new ArgumentNullException();

            return new StringValidator(obj);
        }

        /// <summary>
        /// Validation function for object type
        /// </summary>
        /// <param name="obj">Object to validate</param>
        /// <remarks>Null value is allowed. To check if it is present, use the function <see cref="ObjectValidator.IsNull()">IsNull()</see> or <see cref="ObjectValidator.IsNotNull()">IsNotNull()</see></remarks>
        public static ObjectValidator Validate(object obj) => new(obj);
    }
}
