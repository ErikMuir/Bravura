namespace Bravura.Console.Commands;

public static class ModeCommand
{
    private static readonly FluentConsole _console = new();

    static ModeCommand()
    {
        Command.Handler = CommandHandler.Create<string>(_handler);
    }

    public static readonly Command Command = new("mode") { new Argument<string>("val") };

    private static void _handler(string val)
    {
        if (!Modes.ModesDict.TryGetValue(val.ToLower(), out var mode))
        {
            _console.Failure($"'{val}' is not a known mode!");
            return;
        }

        _console
            .Info($"Mode: {mode}")
            .Info($"Degrees: {mode.Intervals.Select(i => i.ToString().ToAscii())}")
            .Info($"Symbols: {mode.Intervals.Select(i => i.ToString().ToAscii())}");
    }
}
