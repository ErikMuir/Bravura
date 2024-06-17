using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console;

public enum Direction
{
    Up,
    Down,
}

public static class TransposeCommand
{
    private static readonly FluentConsole _console = new();

    static TransposeCommand()
    {
        Command.Handler = CommandHandler.Create<Direction, string, string[]>(_handler);
    }

    public static Command Command = new("transpose")
    {
        new Argument<Direction>("direction", "The direction to transpose (up or down)."),
        new Argument<string>("interval", "The interval in which to transpose."),
        new Argument<string[]>("chords"),
    };

    private static void _handler(Direction direction, string interval, string[] chords)
    {
        if (!Interval.TryParse(interval, out var parsedInterval))
        {
            _console.Failure($"Unrecognized interval: {interval}''");
            return;
        }
        List<Chord> progression = new();
        foreach (string val in chords)
        {
            if (!Chord.TryParse(val, out Chord chord))
            {
                _console.Failure($"Unrecognized chord: '{val}'");
                return;
            }
            progression.Add(chord);
        }
        var transposedProgression = progression.Select(chord =>
        {
            var newRoot = direction == Direction.Down
                ? chord.Root.GetPitchByIntervalBelow(parsedInterval)
                : chord.Root.GetPitchByIntervalBelow(parsedInterval);
            return new Chord(newRoot, chord.Quality);
        });
        _console.Info(string.Join(" ", transposedProgression.Select(c => c.DisplayValue(true))));
    }
}
