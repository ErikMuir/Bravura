namespace Bravura.Common.Utilities;

public static class AsciiConverter
{
    public static string ToAscii(this string source)
        => source.Replace("♭", "b").Replace("♮", "_").Replace("♯", "#");

    public static string FromAscii(this string source)
        => source.Replace("b", "♭").Replace("_", "♮").Replace("#", "♯");
}
