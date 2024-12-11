namespace Bravura.Console.Commands;

public static class ChordProgressionCommand
{
    private static readonly FluentConsole _console = new();

    static ChordProgressionCommand()
    {
        Command.Handler = CommandHandler.Create<string[], bool>(_handler);
    }

    public static readonly Command Command = new("chord-progression")
    {
        new Argument<string[]>("chords"),
        new Option<bool>("--all", "An option to return all analysis and their weights.")
    };

    private static void _handler(string[] chords, bool all)
    {
        if (chords.Length == 0)
        {
            _console.Failure("You must provide at least one chord!");
            return;
        }

        var parsedChords = new List<Chord>();
        foreach (string val in chords)
        {
            if (!Chord.TryParse(val, out var chord))
            {
                _console.Failure($"'{val}' is not a valid chord!");
                return;
            }
            parsedChords.Add(chord);
        }
        var progression = new ChordProgression(parsedChords);

        var rows = progression.Analysis
            .OrderByDescending(analysis => analysis.Weight)
            .Select((analysis, index) => new { analysis, index })
            .Where(x => all || x.index == 0)
            .Select(x => GetAnalysisRow(x.analysis, all))
            .ToList();

        rows.Insert(0, GetHeaderRow(progression, all));

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

    private static readonly TableCellConfig _weightColumn = new() { TextColor = ConsoleColor.DarkCyan };

    private static TableRow GetHeaderRow(ChordProgression prog, bool all)
    {
        List<TableCell> headerRowCells = [
            new TableCell("Key"),
            ..prog.Chords.Select(chord => new TableCell(chord.ToString().ToAscii())),
        ];
        if (all) headerRowCells.Add(new TableCell("Weight", _weightColumn));

        return new TableRow(headerRowCells);
    }

    private static TableRow GetAnalysisRow(ChordProgressionAnalysis analysis, bool all)
    {
        List<TableCell> analysisRowCells = [
            new TableCell(analysis.AnalyzedChords.First().Key.ToString().ToAscii()),
            ..analysis.AnalyzedChords.Select(analyzedChord => new TableCell(analyzedChord.ToString().ToAscii())),
        ];
        if (all) analysisRowCells.Add(new TableCell($"{analysis.Weight}", _weightColumn));

        return new TableRow(analysisRowCells);
    }
}
