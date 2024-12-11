namespace Bravura.Console.Commands;

public static class ChromaticScaleCommand
{
    private static readonly FluentConsole _console = new();

    static ChromaticScaleCommand()
    {
        Command.Handler = CommandHandler.Create<string>(_handler);
    }

    public static readonly Command Command = new("chromatic-scale") { new Argument<string>("root") };

    private static void _handler(string root)
    {
        if (!Pitch.TryParse(root, out var parsedRoot))
        {
            _console.Failure($"'{root}' is not a valid pitch!");
            return;
        }

        ChromaticScale scale = new(parsedRoot);

        _console
            .Info($"Root: {scale.Root.ToString().ToAscii()}")
            .Info($"Pitches: {scale.Pitches.ToJoinedString().ToAscii()}");
    }
}
