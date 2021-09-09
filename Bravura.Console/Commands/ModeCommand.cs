using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ModeCommand
    {
        private static readonly FluentConsole _console = new FluentConsole();

        static ModeCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new Command("mode") { new Argument<string>("val") };

        private static void _handler(string val)
        {
            if (!Bravura.Tonality.Modes.ModesDict.TryGetValue(val.ToLower(), out var mode))
            {
                _console.Failure($"'{val}' is not a known mode!");
                return;
            }

            var degrees = string.Join(" ", mode.Intervals.Select(i => i.ToAsciiString()));
            var symbols = string.Join(" ", mode.Intervals.Select(i => i.Symbol));
            _console.Info($"Mode: {mode.Name}");
            _console.Info($"Degrees: {degrees}");
            _console.Info($"Symbols: {symbols}");
        }
    }
}
