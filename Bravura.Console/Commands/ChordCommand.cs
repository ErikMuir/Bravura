using System.CommandLine;
using System.CommandLine.Invocation;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
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

            string notes = string.Join(" ", chord.AsciiNoteSymbols);
            string chordTones = string.Join(" ", chord.AsciiChordTones);
            _console
                .Info($"Root: {chord.Root.ToAsciiString()}")
                .Info($"Quality: {chord.Quality.AsciiSymbol}")
                .Info($"Notes: {notes}")
                .Info($"Chord Tones: {chordTones}");
        }
    }
}
