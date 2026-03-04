using System.Collections.ObjectModel;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Talaorasan.Shared.Helpers
{
    public static class ObjectExtensions
    {
        private static readonly Regex RomanNumeralRegex =
        new Regex(@"^(?=[MDCLXVI])(M{0,4}(CM|CD|D?C{0,3})
        (XC|XL|L?X{0,3})(IX|IV|V?I{0,3}))$",
        RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.IgnorePatternWhitespace);

        public static string ToTitleCase(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return string.Empty;

            var textInfo = CultureInfo.CurrentCulture.TextInfo;

            var words = value
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];

                if (RomanNumeralRegex.IsMatch(word))
                {
                    words[i] = word.ToUpper();
                }
                else
                {
                    words[i] = textInfo.ToTitleCase(word);
                }
            }

            return string.Join(" ", words);
        }
        public static string GenerateRandomCode(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            if (length <= 0)
                return string.Empty;

            var result = new char[length];
            var buffer = new byte[length];

            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(buffer);

            for (int i = 0; i < length; i++)
            {
                result[i] = chars[buffer[i] % chars.Length];
            }

            return new string(result);
        }
        public static string DefaultDisplayIfEmpty<T>(this T? value, T? defaultValue = null, string display = "N/A")
        where T : class
        {
            if (value == null)
                return display;
            if (defaultValue != null && EqualityComparer<T>.Default.Equals(value, defaultValue))
                return display;
            if (value is string s && string.IsNullOrEmpty(s))
                return display;
            return value.ToString() ?? display;
        }
        public static T[] PaginateToArray<T>(this IEnumerable<T> values, int skip, int take) where T : class
        {
            if (values == null || values.Count() == 0)
                return Array.Empty<T>();

            if (skip == 0 && take == 0)
                return values.ToArray();
            int actualSkip = (skip * take) + (skip % take > 0 ? 1 : 0);
            return values
                .Skip(actualSkip)
                .Take(take)
                .ToArray();
        }
        public static IQueryable<T> Paginate<T>(this IQueryable<T> query, int skip, int take) where T : class
        {
            if (skip == 0 && take == 0)
                return query;
            int actualSkip = (skip * take) + (skip % take > 0 ? 1 : 0);
            return query
                   .Skip(actualSkip)
                   .Take(take);
        }
    }
}
