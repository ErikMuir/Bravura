namespace Bravura.Tonality
{
    public static class StringExtensions
    {
        public static string TrimToNull(this string val)
            => string.IsNullOrWhiteSpace(val) ? null : val.Trim();
    }
}
