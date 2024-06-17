using System.CommandLine;
using System.CommandLine.NamingConventionBinder;
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

            _console
                .Info($"Root: {scale.Root.DisplayValue(true)}")
                .Info($"Pitches: {string.Join(" ", scale.Pitches.Select(p => p.DisplayValue(true)))}");
        }
    }
}
