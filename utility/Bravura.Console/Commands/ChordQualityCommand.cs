namespace Bravura.Console.Commands;

public static class ChordQualityCommand
{
    private static readonly FluentConsole _console = new();

    static ChordQualityCommand()
    {
        Command.Handler = CommandHandler.Create<string>(_handler);
    }

    public static readonly Command Command = new("chord-quality") { new Argument<string>("val") };

    private static void _handler(string val)
    {
        if (!ChordQuality.TryParse(val, out var chordQuality))
        {
            _console.Failure($"'{val}' is not a valid chord quality!");
            return;
        }

        _console
            .Info($"Chord Quality: {chordQuality.ToString().ToAscii()}")
            .Info($"Degrees: {chordQuality.Intervals.Select(i => i.ToString().ToAscii())}")
            .Info($"Symbols: {chordQuality.Intervals.Select(i => i.ToString().ToAscii())}");
    }
}
