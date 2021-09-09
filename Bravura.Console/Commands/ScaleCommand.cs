using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ScaleCommand
    {
        private static readonly FluentConsole _console = new FluentConsole();

        static ScaleCommand()
        {
            Command.Handler = CommandHandler.Create<string, string>(_handler);
        }

        public static Command Command = new Command("scale")
        {
            new Argument<string>("root"),
            new Argument<string>("mode"),
        };

        private static void _handler(string root, string mode)
        {
            if (!Bravura.Tonality.Pitch.TryParse(root, out var parsedRoot))
            {
                _console.Failure($"'{root}' is not a valid pitch!");
                return;
            }
            if (!Bravura.Tonality.Modes.ModesDict.TryGetValue(mode.Trim().ToLower(), out var parsedMode))
            {
                _console.Failure($"'{mode}' is not a known mode!");
                return;
            }
            var scale = new Scale(parsedRoot, parsedMode);

            var pitches = string.Join(" ", scale.Pitches.Select(p => p.ToAsciiString()));
            _console.Info($"Root: {scale.Root.ToAsciiString()}");
            _console.Info($"Mode: {scale.Mode.Name}");
            _console.Info($"Pitches: {pitches}");
        }
    }
}
