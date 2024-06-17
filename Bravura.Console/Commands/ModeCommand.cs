using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ModeCommand
    {
        private static readonly FluentConsole _console = new();

        static ModeCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new("mode") { new Argument<string>("val") };

        private static void _handler(string val)
        {
            if (!Modes.ModesDict.TryGetValue(val.ToLower(), out var mode))
            {
                _console.Failure($"'{val}' is not a known mode!");
                return;
            }

            _console
                .Info($"Mode: {mode}")
                .Info($"Degrees: {string.Join(" ", mode.Intervals.Select(i => i.DisplayValue(true)))}")
                .Info($"Symbols: {string.Join(" ", mode.Intervals.Select(i => i.DisplayValue(true)))}");
        }
    }
}
