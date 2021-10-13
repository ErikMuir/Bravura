using System.Linq;
using System.CommandLine;
using System.CommandLine.Invocation;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ChordQualityCommand
    {
        private static readonly FluentConsole _console = new();

        static ChordQualityCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new("chord-quality") { new Argument<string>("val") };

        private static void _handler(string val)
        {
            if (!ChordQuality.TryParse(val, out var chordQuality))
            {
                _console.Failure($"'{val}' is not a valid chord quality!");
                return;
            }

            string degrees = string.Join(" ", chordQuality.Intervals.Select(i => i.ToAsciiString()));
            string symbols = string.Join(" ", chordQuality.Intervals.Select(i => i.Symbol));
            _console
                .Info($"Chord Quality: {chordQuality.AsciiSymbol}")
                .Info($"Degrees: {degrees}")
                .Info($"Symbols: {symbols}");
        }
    }
}
