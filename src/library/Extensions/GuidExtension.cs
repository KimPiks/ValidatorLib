using System;

namespace ValidatorLib.Extensions
{
    /// <summary>
    /// Class extending the validation class
    /// </summary>
    internal static class GuidExtension
    {
        /// <summary>
        /// Validate if object is empty
        /// </summary>
        /// <param name="guid">Guid</param>
        /// <returns>True if is empty</returns>
        internal static bool IsEmpty(this Guid guid) =>
            guid == Guid.Empty;
    }
}
