using System.Collections.Generic;
using System.Text.RegularExpressions;
using ValidatorLib.Validators;

namespace ValidatorLib.Extensions
{
    /// <summary>
    /// Class extending the validation class
    /// </summary>
    internal static class StringExtension
    {
        /// <summary>
        /// Regex to the specified CharType
        /// </summary>
        private static readonly Dictionary<StringValidator.CharType, string> CharTypeRegex = new()
        {
            [StringValidator.CharType.BigLetters] = "[A-Z]",
            [StringValidator.CharType.SmallLetters] = "[a-z]",
            [StringValidator.CharType.Numbers] = "[0-9]",
            [StringValidator.CharType.Alphanumerical] = @"[\W]"
        };

        /// <summary>
        /// Validate if object is an email address
        /// </summary>
        /// <param name="email">Object</param>
        /// <returns>True if string is an email address</returns>
        internal static bool IsEmailAddress(this string email) =>
            Regex.IsMatch(email,
                @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-||_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+([a-z]+|\d|-|\.{0,1}|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])?([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$");

        /// <summary>
        /// Validate if object is a phone number
        /// </summary>
        /// <param name="str">Object</param>
        /// <returns>True if string is a phone number</returns>
        internal static bool IsPhoneNumber(this string str) =>
            Regex.IsMatch(str, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$");

        /// <summary>
        /// Validate if string is longer than the specified value
        /// </summary>
        /// <param name="str">String</param>
        /// <param name="min">String min length</param>
        /// <returns>True if string is longer than the specified value</returns>
        internal static bool MinLength(this string str, int min) =>
            str.Length >= min;

        /// <summary>
        /// Validate if string is shorter than the specified value
        /// </summary>
        /// <param name="str">String</param>
        /// <param name="max">String max length</param>
        /// <returns>True if string is shorter than the specified value</returns>
        internal static bool MaxLength(this string str, int max) =>
            str.Length <= max;

        /// <summary>
        /// Validate if string is empty
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>True if string is empty</returns>
        internal static bool IsEmpty(this string str) =>
            str == "";

        /// <summary>
        /// Validate if string is not empty
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>True if string is not empty</returns>
        internal static bool IsNotEmpty(this string str) =>
            str != "";

        /// <summary>
        /// Validate if string contains only the specified CharType
        /// </summary>
        /// <param name="str">String</param>
        /// <param name="charType">CharType</param>
        /// <returns>True if string contains only the specified CharType</returns>
        internal static bool Only(this string str, StringValidator.CharType charType) =>
            Regex.IsMatch(str, $@"^{CharTypeRegex[charType]}*$");

        /// <summary>
        /// Validate if string contains the specified CharType
        /// </summary>
        /// <param name="str">String</param>
        /// <param name="charType">CharType</param>
        /// <returns>True if string contains the specified CharType</returns>
        internal static bool Contains(this string str, StringValidator.CharType charType) =>
            Regex.IsMatch(str, $@"^.*{CharTypeRegex[charType]}.*$");
    }
}
