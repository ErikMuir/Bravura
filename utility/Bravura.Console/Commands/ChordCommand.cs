namespace Bravura.Console.Commands;

public static class ChordCommand
{
    private static readonly FluentConsole _console = new();

    static ChordCommand()
    {
        Command.Handler = CommandHandler.Create<string>(_handler);
    }

    public static readonly Command Command = new("chord") { new Argument<string>("val") };

    private static void _handler(string val)
    {
        if (!Chord.TryParse(val, out var chord))
        {
            _console.Failure($"'{val}' is not a valid chord!");
            return;
        }

        _console
            .Info($"Root: {chord.Root.ToString().ToAscii()}")
            .Info($"Quality: {chord.Quality.ToString().ToAscii()}")
            .Info($"Notes: {chord.Pitches.ToString().ToAscii()}")
            .Info($"Chord Tones: {chord.Quality.Intervals.ToString().ToAscii()}");
    }
}
