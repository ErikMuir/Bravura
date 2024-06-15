namespace Bravura.Common
{
    public static class StringExtensions
    {
        public static string TrimToNull(this string val)
            => string.IsNullOrWhiteSpace(val) ? null : val.Trim();

        public static string SafeTrim(this string val)
            => val?.Trim();
    }
}
