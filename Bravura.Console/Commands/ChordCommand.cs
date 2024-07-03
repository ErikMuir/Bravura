using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console.Commands;

public static class ChordCommand
{
    private static readonly FluentConsole _console = new();

    static ChordCommand()
    {
        Command.Handler = CommandHandler.Create<string>(_handler);
    }

    public static Command Command = new("chord") { new Argument<string>("val") };

    private static void _handler(string val)
    {
        if (!Chord.TryParse(val, out var chord))
        {
            _console.Failure($"'{val}' is not a valid chord!");
            return;
        }

        _console
            .Info($"Root: {chord.Root.DisplayValue(true)}")
            .Info($"Quality: {chord.Quality.DisplayValue(true)}")
            .Info($"Notes: {string.Join(" ", chord.Pitches.DisplayValue(true))}")
            .Info($"Chord Tones: {string.Join(" ", chord.Quality.Intervals.DisplayValue(true))}");
    }
}
