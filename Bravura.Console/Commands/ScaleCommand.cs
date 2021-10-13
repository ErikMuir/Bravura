using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ScaleCommand
    {
        private static readonly FluentConsole _console = new();

        static ScaleCommand()
        {
            Command.Handler = CommandHandler.Create<string, string>(_handler);
        }

        public static Command Command = new("scale")
        {
            new Argument<string>("root"),
            new Argument<string>("mode"),
        };

        private static void _handler(string root, string mode)
        {
            Pitch parsedRoot;
            Mode parsedMode;

            if (!Pitch.TryParse(root, out parsedRoot))
            {
                _console.Failure($"'{root}' is not a valid pitch!");
                return;
            }
            if (!Modes.ModesDict.TryGetValue(mode.Trim().ToLower(), out parsedMode))
            {
                _console.Failure($"'{mode}' is not a known mode!");
                return;
            }

            Scale scale = new(parsedRoot, parsedMode);

            string pitches = string.Join(" ", scale.Pitches.Select(p => p.ToAsciiString()));
            _console
                .Info($"Root: {scale.Root.ToAsciiString()}")
                .Info($"Mode: {scale.Mode.Name}")
                .Info($"Pitches: {pitches}");
        }
    }
}
