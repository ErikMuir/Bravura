namespace Bravura.Console.Commands;

public static class TransposeCommand
{
    private static readonly FluentConsole _console = new();

    static TransposeCommand()
    {
        Command.Handler = CommandHandler.Create<Direction, string, string[]>(_handler);
    }

    public static readonly Command Command = new("transpose")
    {
        new Argument<Direction>("direction", "The direction to transpose (up or down)."),
        new Argument<string>("interval", "The interval in which to transpose."),
        new Argument<string[]>("chords", "A space-separated list of chords to be transposed."),
    };

    private static void _handler(Direction direction, string interval, string[] chords)
    {
        if (!Interval.TryParse(interval, out var parsedInterval))
        {
            _console.Failure($"Unrecognized interval: {interval}''");
            return;
        }

        List<Chord> originalProgression = new();
        foreach (string val in chords)
        {
            if (!Chord.TryParse(val, out Chord chord))
            {
                _console.Failure($"Unrecognized chord: '{val}'");
                return;
            }
            originalProgression.Add(chord);
        }

        var transposedProgression = originalProgression.Select(chord => chord.Transpose(direction, parsedInterval));

        _console.Info(transposedProgression.ToJoinedString().ToAscii());
    }
}
