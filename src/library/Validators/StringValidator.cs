using System;
using ValidatorLib.Extensions;

namespace ValidatorLib.Validators
{
    /// <summary>
    /// Validation methods
    /// </summary>
    public class StringValidator
    {
        /// <summary>
        /// Object to be checked 
        /// </summary>
        private static string _objToValidate;

        /// <summary>
        /// Assign the object to be checked to a variable
        /// </summary>
        /// <param name="obj">Object to be checked</param>
        public StringValidator(string obj) =>
            _objToValidate = obj;

        /// <summary>
        /// Validate if object is an email address
        /// </summary>
        /// <exception cref="ArgumentException">Object is not an email address</exception>
        public StringValidator IsEmailAddress()
        {
            if (!_objToValidate.IsEmailAddress())
                throw new ArgumentException("Email address is not valid");

            return this;
        }

        /// <summary>
        /// Validate if object is a phone number
        /// </summary>
        /// <exception cref="ArgumentException">Object is not a phone number</exception>
        public StringValidator IsPhoneNumber()
        {
            if (!_objToValidate.IsPhoneNumber())
                throw new ArgumentException("Phone number is not valid");

            return this;
        }

        /// <summary>
        /// Validate if object is longer than the specified value
        /// </summary>
        /// <param name="min">String min length</param>
        /// <exception cref="ArgumentException">The object is shorter than the specified value</exception>
        public StringValidator MinLength(int min)
        {
            if (!_objToValidate.MinLength(min))
                throw new ArgumentException($"The specified string is shorter than {min} characters");

            return this;
        }

        /// <summary>
        /// Validate if object is shorter than the specified value
        /// </summary>
        /// <param name="max">String max length</param>
        /// <exception cref="ArgumentException">The object is longer than the specified value</exception>
        public StringValidator MaxLength(int max)
        {
            if (!_objToValidate.MaxLength(max))
                throw new ArgumentException($"The specified string is longer than {max} characters");

            return this;
        }

        /// <summary>
        /// Validate if object is empty
        /// </summary>
        /// <exception cref="ArgumentException">The object is not empty</exception>
        public StringValidator IsEmpty()
        {
            if (_objToValidate.IsNotEmpty())
                throw new ArgumentException("The specified string is not empty");

            return this;
        }

        /// <summary>
        /// Validate if object is not empty
        /// </summary>
        /// <exception cref="ArgumentException">The object is empty</exception>
        public StringValidator IsNotEmpty()
        {
            if (StringExtension.IsEmpty(_objToValidate))
                throw new ArgumentException("The specified string is empty");

            return this;
        }

        /// <summary>
        /// Validate if object contains only specified CharType
        /// </summary>
        /// <param name="charType">CharType</param>
        /// <exception cref="ArgumentException">The object doesn't contain only specified CharType</exception>
        public StringValidator Only(CharType charType)
        {
            if (!_objToValidate.Only(charType))
                throw new ArgumentException($"The given string does not contain only {charType}");

            return this;
        }

        /// <summary>
        /// Validate if object contains specified CharType
        /// </summary>
        /// <param name="charType">CharType</param>
        /// <exception cref="ArgumentException">The object doesn't contain specified CharType</exception>
        public StringValidator Contains(CharType charType)
        {
            if (!_objToValidate.Contains(charType))
                throw new ArgumentException($"The given string does not contain {charType}");

            return this;
        }

        /// <summary>
        /// CharType used for the Only() and Contains() methods
        /// </summary>
        public enum CharType
        {
            BigLetters,
            SmallLetters,
            Numbers,
            Alphanumerical
        }
    }
}
