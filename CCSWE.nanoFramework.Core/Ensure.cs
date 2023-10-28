using System;

namespace CCSWE.nanoFramework
{
    // Copied over from https://github.com/CoryCharlton/CCSWE.Core/blob/master/src/Core/Ensure.cs

    /// <summary>
    /// A helper class for ensuring parameter conditions.
    /// </summary>
    public static class Ensure
    {
        private static Exception GetException(Type exception, string name, string? message)
        {
            if (exception == typeof(ArgumentNullException))
            {
                return new ArgumentNullException(name, message);
            }

            if (exception == typeof(ArgumentOutOfRangeException))
            {
                return new ArgumentOutOfRangeException(name, message);
            }

            if (exception == typeof(IndexOutOfRangeException))
            {
                return new IndexOutOfRangeException(message);
            }

            if (exception == typeof(InvalidOperationException))
            {
                return new InvalidOperationException(message);
            }

            // Defaulting to ArgumentException. This all worked better with generics :)
            return new ArgumentException(message, name);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if the expression evaluates to <c>false</c>.
        /// </summary>
        /// <param name="name">The name of the parameter we are validating.</param>
        /// <param name="expression">The expression that will be evaluated.</param>
        /// <param name="message">The message associated with the <see cref="Exception"/></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the expression evaluates to <c>false</c></exception>.
        public static void IsInRange(string name, bool expression, string? message = null)
        {
            IsValid(typeof(ArgumentOutOfRangeException), name, expression, string.IsNullOrEmpty(message) ? $"The value passed for '{name}' is out of range." : message);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentNullException"/> if the value is <c>null</c>.
        /// </summary>
        /// <param name="name">The name of the parameter we are validating.</param>
        /// <param name="value">The value that will be evaluated.</param>
        /// <param name="message">The message associated with the <see cref="Exception"/></param>
        /// <exception cref="ArgumentNullException">Thrown when the value is <c>null</c></exception>.
        public static void IsNotNull(string name, object? value, string? message = null)
        {
            IsValid(typeof(ArgumentNullException), name, value is not null, string.IsNullOrEmpty(message) ? $"The value passed for '{name}' is null." : message);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the value is <c>null</c> or <c>whitespace</c>.
        /// </summary>
        /// <param name="name">The name of the parameter we are validating.</param>
        /// <param name="value">The value that will be evaluated.</param>
        /// <param name="message">The message associated with the <see cref="Exception"/></param>
        /// <exception cref="ArgumentException">Thrown when the value is <c>null</c> or <c>whitespace</c>.</exception>.
        public static void IsNotNullOrEmpty(string name, string? value, string? message = null)
        {
            IsValid(typeof(ArgumentException), name, !string.IsNullOrEmpty(value), string.IsNullOrEmpty(message) ? $"The value passed for '{name}' is empty or null." : message);
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> if the expression evaluates to <c>false</c>.
        /// </summary>
        /// <param name="name">The name of the parameter we are validating.</param>
        /// <param name="expression">The expression that will be evaluated.</param>
        /// <param name="message">The message associated with the <see cref="Exception"/></param>
        /// <exception cref="ArgumentException">Thrown when the expression evaluates to <c>false</c></exception>.
        public static void IsValid(string name, bool expression, string? message = null)
        {
            IsValid(typeof(ArgumentException), name, expression, string.IsNullOrEmpty(message) ? $"The value passed for '{name}' is not valid." : message);
        }

        /// <summary>
        /// Throws an exception if the expression evaluates to <c>false</c>.
        /// </summary>
        /// <param name="exception">The type of the exception to throw.</param>
        /// <param name="name">The name of the parameter we are validating.</param>
        /// <param name="expression">The expression that will be evaluated.</param>
        /// <param name="message">The message associated with the <see cref="Exception"/></param>
        public static void IsValid(Type exception, string name, bool expression, string? message = null)
        {
            if (expression)
            {
                return;
            }

            throw GetException(exception, name, string.IsNullOrEmpty(message) ? $"The value passed for '{name}' is not valid." : message);
        }
    }
}
