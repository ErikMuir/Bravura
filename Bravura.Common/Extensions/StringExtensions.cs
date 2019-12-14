namespace Bravura.Common
{
    public static class StringExtensions
    {
        public static string TrimToNull(this string val)
            => string.IsNullOrWhiteSpace(val) ? null : val.Trim();
    }
}
