namespace Bravura.Common.Utilities;

public static class AsciiConverter
{
    public static string ToAscii(this string source, string natural = null) =>
        source.Replace("♭", "b").Replace("♯", "#").Replace("♮", $"{natural}");

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
