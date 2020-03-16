using System.CommandLine;
using System.CommandLine.Invocation;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class PitchCommand
    {
        private static readonly FluentConsole _console = new FluentConsole();

        static PitchCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new Command("pitch") { new Argument<string>("val") };

        private static void _handler(string val)
        {
            if (!Pitch.TryParse(val, out var pitch))
            {
                _console.Failure($"'{val}' is not a valid pitch!");
                return;
            }

            _console.Info($"Pitch: {pitch.ToAsciiString()}");
            _console.Info($"Semitones Above C Natural: {pitch.SemitonesAboveC}");
            _console.Info($"Logical: {pitch.Logical().ToAsciiString()}");
        }
    }
}
