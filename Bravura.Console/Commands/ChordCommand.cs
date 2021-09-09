using System.CommandLine;
using System.CommandLine.Invocation;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ChordCommand
    {
        private static readonly FluentConsole _console = new FluentConsole();

        static ChordCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new Command("chord") { new Argument<string>("val") };

        private static void _handler(string val)
        {
            if (!Bravura.Tonality.Chord.TryParse(val, out var chord))
            {
                _console.Failure($"'{val}' is not a valid chord!");
                return;
            }

            var notes = string.Join(" ", chord.AsciiNoteSymbols);
            var chordTones = string.Join(" ", chord.AsciiChordTones);
            _console.Info($"Root: {chord.Root.ToAsciiString()}");
            _console.Info($"Quality: {chord.Quality.AsciiSymbol}");
            _console.Info($"Notes: {notes}");
            _console.Info($"Chord Tones: {chordTones}");
        }
    }
}
