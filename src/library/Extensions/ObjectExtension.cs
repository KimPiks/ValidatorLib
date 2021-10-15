namespace ValidatorLib.Extensions
{
    /// <summary>
    /// Class extending the validation class
    /// </summary>
    internal static class ObjectExtension
    {
        /// <summary>
        /// Validate if object is null
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True if object is null</returns>
        internal static bool IsNull(this object obj) =>
            obj == null;

        /// <summary>
        /// Validate if object is not null
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True if object is not null</returns>
        internal static bool IsNotNull(this object obj) =>
            obj != null;
    }
}
