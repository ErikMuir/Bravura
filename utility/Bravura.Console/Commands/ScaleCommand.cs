namespace Bravura.Console.Commands;

public static class ScaleCommand
{
    private static readonly FluentConsole _console = new();

    static ScaleCommand()
    {
        Command.Handler = CommandHandler.Create<string, string>(_handler);
    }

    public static readonly Command Command = new("scale")
        {
            new Argument<string>("root"),
            new Argument<string>("mode"),
        };

    private static void _handler(string root, string mode)
    {
        if (!Pitch.TryParse(root, out var parsedRoot))
        {
            _console.Failure($"'{root}' is not a valid pitch!");
            return;
        }
        if (!Modes.ModesDict.TryGetValue(mode.Trim().ToLower(), out var parsedMode))
        {
            _console.Failure($"'{mode}' is not a known mode!");
            return;
        }

        Scale scale = new(parsedRoot, parsedMode);

        _console
            .Info($"Root: {scale.Root.ToString().ToAscii()}")
            .Info($"Mode: {scale.Mode.ToString().ToAscii()}")
            .Info($"Pitches: {scale.Pitches.Select(p => p.ToString().ToAscii())}");
    }
}
