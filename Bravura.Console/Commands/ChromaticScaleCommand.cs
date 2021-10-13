using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ChromaticScaleCommand
    {
        private static readonly FluentConsole _console = new();

        static ChromaticScaleCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new("chromatic-scale") { new Argument<string>("root") };

        private static void _handler(string root)
        {
            if (!Pitch.TryParse(root, out var parsedRoot))
            {
                _console.Failure($"'{root}' is not a valid pitch!");
                return;
            }

            ChromaticScale scale = new(parsedRoot);

            string pitches = string.Join(" ", scale.Pitches.Select(p => p.ToAsciiString()));
            _console
                .Info($"Root: {scale.Root.ToAsciiString()}")
                .Info($"Pitches: {pitches}");
        }
    }
}
