using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Linq;
using System.Text.Json;
using MuirDev.ConsoleTools;
using Bravura.Tonality;
using Bravura.Tonality.Analysis;

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
        if (chords.Length == 0)
        {
            _console.Failure("You must provide at least one chord!");
            return;
        }

        var parsedChords = new List<Chord>();
        foreach (string val in chords)
        {
            if (!Chord.TryParse(val, out Chord chord))
            {
                _console.Failure($"'{val}' is not a valid chord!");
                return;
            }
            parsedChords.Add(chord);
        }
        var progression = new ChordProgression(parsedChords);

        List<TableRow> rows = [GetHeaderRow(progression)];
        rows.AddRange(progression.Analysis.Select(analysis => GetAnalysisRow(analysis)));

        var table = new Table(rows, new TableConfig
        {
            TableBorder = true,
            ColumnBorder = true,
            HasColumnLabels = true,
            HasRowLabels = true,
            BorderColor = ConsoleColor.DarkGray,
        });
        table.Display();
    }

    private static TableRow GetHeaderRow(ChordProgression prog)
    {
        var headerRowCells = new List<TableCell>();

        headerRowCells.Add(new("Key"));
        headerRowCells.AddRange(prog.Chords.Select(chord => new TableCell(chord.DisplayValue(true))));
        headerRowCells.Add(new("Weight"));

        return new TableRow(headerRowCells);
    }

    private static TableRow GetAnalysisRow(ChordProgressionAnalysis analysis)
    {
        var analysisRowCells = new List<TableCell>();

        analysisRowCells.Add(new(analysis.AnalyzedChords.First().Key.DisplayValue(true)));
        analysisRowCells.AddRange(analysis.AnalyzedChords.Select(analyzedChord => new TableCell(analyzedChord.DisplayValue(true))));
        analysisRowCells.Add(new("todo"));

        return new TableRow(analysisRowCells);
    }
}
