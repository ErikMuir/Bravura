using System.CommandLine;
using System.CommandLine.Invocation;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ChordProgressionCommand
    {
        private static readonly FluentConsole _console = new FluentConsole();

        static ChordProgressionCommand()
        {
            Command.Handler = CommandHandler.Create<string[]>(_handler);
        }

        public static Command Command = new Command("chord-progression") { new Argument<string[]>("chords") };

        private static void _handler(string[] chords)
        {
            _console.Failure($"That command is not yet implemented!");
        }
    }
}
