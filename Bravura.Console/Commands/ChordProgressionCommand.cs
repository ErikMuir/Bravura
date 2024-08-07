using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console.Commands;

public static class ChordProgressionCommand
{
    private static readonly FluentConsole _console = new();

    static ChordProgressionCommand()
    {
        Command.Handler = CommandHandler.Create<string[]>(_handler);
    }

    public static Command Command = new("chord-progression") { new Argument<string[]>("chords") };

    private static void _handler(string[] chords)
    {
        List<Chord> progression = new();
        foreach (string val in chords)
        {
            if (!Chord.TryParse(val, out Chord chord))
            {
                _console.Failure($"'{val}' is not a valid chord!");
                return;
            }
            progression.Add(chord);
        }

        List<Pitch> pitches = progression
            .Select(c => c.Pitches)
            .SelectMany(p => p)
            .DistinctBy(pitches => pitches.DisplayValue(true))
            .ToList();

        List<Key> keys = Keys.AllKeys
            .Where(key =>
            {
                foreach (Pitch pitch in pitches)
                {
                    if (!key.Scale.Pitches.Contains(pitch))
                    {
                        return false;
                    }
                }
                return true;
            })
            .ToList();

        switch (keys.Count)
        {
            case 0:
                _console.Failure("Currently only supports diatonic chord progressions!");
                return;
            case 1:
                Key key = keys[0];
                _console.Info($"Key: {key.Root.DisplayValue(true)} {key.Modality}");
                return;
            default:
                _console.Info("Possible Keys:");
                keys.ForEach(key => _console.Info($"{key.Root.DisplayValue(true)} {key.Modality}"));
                return;
        }
    }
}
