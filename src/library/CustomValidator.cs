using System;
using System.Collections.Generic;

namespace ValidatorLib
{
    /// <summary>
    /// A class for creating your own validators
    /// </summary>
    /// <typeparam name="T">The data type to validate</typeparam>
    public class CustomValidator<T>
    {
        /// <summary>
        /// A list of rules that the checked object must comply with.
        /// </summary>
        private readonly List<Func<T, object>> _rules = new();

        /// <summary>
        /// Adding a policy to the list of policies
        /// </summary>
        /// <param name="rule">Rule</param>
        /// <example>validator.AddRule(x => Validator.Validate(user.Email).IsEmailAddress());</example>
        public void AddRule(Func<T, object> rule) =>
            _rules.Add(rule);

        /// <summary>
        /// Validate your model
        /// </summary>
        /// <param name="model">Object to validate</param>
        /// <returns>True if is valid</returns>
        public bool Validate(T model)
        {
            if (_rules == null)
                return true;

            foreach (var rule in _rules)
            {
                rule(model);
            }

            return true;
        }
    }
}
