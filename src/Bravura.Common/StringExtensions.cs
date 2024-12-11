namespace Bravura.Common;

public static class StringExtensions
{
    public static bool IsNullOrWhiteSpace(this string val)
        => string.IsNullOrWhiteSpace(val);

    public static string TrimToNull(this string val)
        => val.IsNullOrWhiteSpace() ? null : val.Trim();

    public static string SafeTrim(this string val)
        => val?.Trim();

    public static string ToAscii(this string source, string natural = null)
        => source.Replace("♭", "b").Replace("♯", "#").Replace("♮", $"{natural}");

    public static string FromAscii(this string source, string natural = null)
    {
        source = source.Replace("b", "♭").Replace("#", "♯");
        if (!natural.IsNullOrWhiteSpace())
        {
            source = source.Replace($"{natural}", "♮");
        }
        return source;
    }
}
