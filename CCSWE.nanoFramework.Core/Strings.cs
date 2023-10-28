using System;
using System.Text;

namespace CCSWE.nanoFramework
{
    /// <summary>
    /// Extension methods for <see cref="String"/>.
    /// </summary>
    public static class Strings
    {
        public static string Join(string? separator, params string[]? values)
        {
            Ensure.IsNotNull(nameof(values), values);

            if (values.Length == 0)
            {
                return string.Empty;
            }

            if (values.Length == 1)
            {
                return values[0];
            }

            var join = new StringBuilder();
            
            for (var i = 0; i < values.Length; i++)
            {
                join.Append(values[i]);

                if (i < values.Length - 1)
                {
                    join.Append(separator);
                }
            }

            return join.ToString();
        }
    }
}
