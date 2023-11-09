using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CCSWE.nanoFramework
{
    /// <summary>
    /// Extension methods for <see cref="String"/>.
    /// </summary>
    public static class Strings
    {
        /// <summary>
        /// Concatenates all the elements of a string array, using the specified separator between each element.
        /// </summary>
        /// <param name="separator">The string to use as a separator. <paramref name="separator"/> is included in the returned string only if <paramref name="value"/> has more than one element.</param>
        /// <param name="value">An array that contains the elements to concatenate.</param>
        /// <returns>
        /// A string that consists of the elements in <paramref name="value"/> delimited by the <paramref name="separator"/> string.
        /// 
        /// -or-
        /// 
        /// <see cref="string.Empty"/> if values has zero elements.
        /// </returns>
        public static string Join(string? separator, [NotNull] params string[]? value)
        {
            Ensure.IsNotNull(nameof(value), value);

            if (value.Length == 0)
            {
                return string.Empty;
            }

            if (value.Length == 1)
            {
                return value[0];
            }

            var join = new StringBuilder();
            
            for (var i = 0; i < value.Length; i++)
            {
                join.Append(value[i]);

                if (i < value.Length - 1)
                {
                    join.Append(separator);
                }
            }

            return join.ToString();
        }
    }
}
