namespace ValidatorLib.Extensions
{
    /// <summary>
    /// Class extending the validation class
    /// </summary>
    internal static class IntExtension
    {
        /// <summary>
        /// Validate if number is positive
        /// </summary>
        /// <param name="num">Number</param>
        /// <returns>True if number is positive</returns>
        internal static bool IsPositive(this int num) => 
            num > 0;

        /// <summary>
        /// Validate if number is negative
        /// </summary>
        /// <param name="num">Number</param>
        /// <returns>True if number is negative</returns>
        internal static bool IsNegative(this int num) =>
            num < 0;
    }
}
