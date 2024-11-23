using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;
using Bravura.Tonality.Analysis;

namespace Bravura.Console.Commands;

public static class ChordalRelationshipCommand
{
    private static readonly FluentConsole _console = new();

    static ChordalRelationshipCommand()
    {
        Command.Handler = CommandHandler.Create<string, string>(_handler);
    }

    public static Command Command = new("chordal-relationship")
    {
        new Argument<string>("chord1"),
        new Argument<string>("chord2"),
    };

    private static void _handler(string chord1, string chord2)
    {
        if (!Chord.TryParse(chord1, out var parsedChord1))
        {
            _console.Failure($"'{chord1}' is not a valid chord!");
            return;
        }

        if (!Chord.TryParse(chord2, out var parsedChord2))
        {
            _console.Failure($"'{chord1}' is not a valid chord!");
            return;
        }

        var chordalRelationship = new ChordalRelationship(parsedChord1, parsedChord2);

        var rows = new List<TableRow>();
        rows.Add(new(
            [
                new(""),
                new(chordalRelationship.Chord1.DisplayValue(true)),
                new(chordalRelationship.Chord2.DisplayValue(true)),
                new("Weight")
            ]));
        foreach (var keyValuePair in chordalRelationship.Analysis.OrderByDescending(a => a.Value.Weight))
        {
            rows.Add(new(
                [
                    new(keyValuePair.Key.DisplayValue(true)),
                    new(keyValuePair.Value.AnalyzedChords[0].DisplayValue(true)),
                    new(keyValuePair.Value.AnalyzedChords[1].DisplayValue(true)),
                    new(keyValuePair.Value.Weight.ToString()),
                ]));
        }
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
}
