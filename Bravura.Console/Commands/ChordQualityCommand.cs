using System.Linq;
using System.CommandLine;
using System.CommandLine.Invocation;
using MuirDev.ConsoleTools;

namespace Bravura.Console
{
    public static class ChordQualityCommand
    {
        private static readonly FluentConsole _console = new FluentConsole();

        static ChordQualityCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new Command("chord-quality") { new Argument<string>("val") };

        private static void _handler(string val)
        {
            if (!Bravura.Tonality.ChordQuality.TryParse(val, out var chordQuality))
            {
                _console.Failure($"'{val}' is not a valid chord quality!");
                return;
            }

            var degrees = string.Join(" ", chordQuality.Intervals.Select(i => i.ToAsciiString()));
            var symbols = string.Join(" ", chordQuality.Intervals.Select(i => i.Symbol));
            _console.Info($"Chord Quality: {chordQuality.AsciiSymbol}");
            _console.Info($"Degrees: {degrees}");
            _console.Info($"Symbols: {symbols}");
        }
    }
}
