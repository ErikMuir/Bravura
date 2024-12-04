namespace Bravura.Common.Extensions;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace(this string val)
        => string.IsNullOrWhiteSpace(val);

    public static string TrimToNull(this string val)
        => val.IsNullOrWhiteSpace() ? null : val.Trim();

    public static string SafeTrim(this string val)
        => val?.Trim();
}
