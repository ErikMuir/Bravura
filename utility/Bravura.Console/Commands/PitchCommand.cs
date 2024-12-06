namespace Bravura.Console.Commands;

public static class PitchCommand
{
    private static readonly FluentConsole _console = new();

    static PitchCommand()
    {
        Command.Handler = CommandHandler.Create<string>(_handler);
    }

    public static readonly Command Command = new("pitch") { new Argument<string>("val") };

    private static void _handler(string val)
    {
        if (!Pitch.TryParse(val, out var pitch))
        {
            _console.Failure($"'{val}' is not a valid pitch!");
            return;
        }

        _console
            .Info($"Pitch: {pitch.ToString().ToAscii()}")
            .Info($"Semitones Above C Natural: {pitch.SemitonesAboveC}")
            .Info($"Logical: {pitch.Logical.ToString().ToAscii()}");
    }
}
