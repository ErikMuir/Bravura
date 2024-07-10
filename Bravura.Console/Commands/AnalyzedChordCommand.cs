using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using MuirDev.ConsoleTools;
using Bravura.Tonality;
using Bravura.Tonality.Analysis;

namespace Bravura.Console.Commands;

public static class AnalyzedChordCommand
{
    private static readonly FluentConsole _console = new();

    static AnalyzedChordCommand()
    {
        Command.Handler = CommandHandler.Create<string, string>(_handler);
    }

    public static Command Command = new("analyze-chord")
    {
        new Argument<string>("chord"),
        new Argument<string>("key"),
    };

    private static void _handler(string chord, string key)
    {
        if (!Chord.TryParse(chord, out var parsedChord))
        {
            _console.Failure($"'{chord}' is not a valid chord!");
            return;
        }

        if (!Key.TryParse(key, out var parsedKey))
        {
            _console.Failure($"'{key}' is not a valid key!");
            return;
        }

        var analyzedChord = new AnalyzedChord(parsedChord, parsedKey);

        _console.Info(analyzedChord.RomanNumeralAnalysis(true));
    }
}
