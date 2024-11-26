using System.Diagnostics;

namespace SharedExtensions
{
    public static class StringExtensions
    {
        // TODO : Fix it, understood wrong the length of
        // acutal API Keys given by VNDB. This wont work.
        public static string ToUsableKey(this string value)
        {
            // Means that either way, it is a wrong key so returning nothing.
            if (value.Length != 19 && value.Length != 16) return string.Empty;
            // Even if it wrong, we cant really parse a key that contain them.
            if (value.Contains('-')) return value;

            var arr = Enumerable.Range(0, 4)
                .Select(i => value.Substring(i * 4, 4));
            return string.Join('-', arr);
        }
    }
}
