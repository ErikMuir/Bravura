using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public class App
    {
        private static readonly FluentConsole _console = new FluentConsole();

        private readonly string[] Args;
        private readonly RootCommand RootCommand;
        private readonly Command ChordQualityCommand;
        private readonly Command ChordCommand;
        private readonly Command ModeCommand;
        private readonly Command ScaleCommand;
        private readonly Command ChordProgressionCommand;

        public App(string[] args)
        {
            Args = args;

            ChordQualityCommand = new Command("chord-quality") { new Argument<string>("val") };
            ChordQualityCommand.Handler = CommandHandler.Create<string>(ChordQualityCommandHandler);

            ChordCommand = new Command("chord") { new Argument<string>("val") };
            ChordCommand.Handler = CommandHandler.Create<string>(ChordCommandHandler);

            ModeCommand = new Command("mode") { new Argument<string>("val") };
            ModeCommand.Handler = CommandHandler.Create<string>(ModeCommandHandler);

            ScaleCommand = new Command("scale") { new Argument<string>("val") };
            ScaleCommand.Handler = CommandHandler.Create<string>(ScaleCommandHandler);

            ChordProgressionCommand = new Command("chord-progression") { new Argument<string>("val") };
            ChordProgressionCommand.Handler = CommandHandler.Create<string>(ChordProgressionCommandHandler);

            RootCommand = new RootCommand("A console app demonstrating the Bravura dotnet music theory library")
            {
                ChordQualityCommand,
                ChordCommand,
                ModeCommand,
                ScaleCommand,
                ChordProgressionCommand,
            };
            RootCommand.Handler = CommandHandler.Create<Command>(RootCommandHandler);
        }

        public Task<int> Run()
        {
            return RootCommand.InvokeAsync(Args);
        }

        private void RootCommandHandler(Command command)
        {
            if (command == null)
            {
                _console.Failure("Required command missing").LineFeed();
                RootCommand.Invoke("-h");
            }
        }

        private static void ChordQualityCommandHandler(string val)
        {
            if (!ChordQuality.TryParse(val, out var chordQuality))
            {
                _console.Failure($"'{val}' is not a valid chord quality!");
                return;
            }

            var degrees = string.Join(" ", chordQuality.Intervals.Select(i => i.ToAsciiString()));
            var symbols = string.Join(" ", chordQuality.Intervals.Select(i => i.Symbol));
            _console.Info($"Chord Quality: {chordQuality.AsciiSymbol}");
            _console.Info($"Degrees: {degrees}");
            _console.Info($"Symbols: {symbols}");
        }

        private static void ChordCommandHandler(string val)
        {
            throw new NotImplementedException();
        }

        private static void ModeCommandHandler(string val)
        {
            throw new NotImplementedException();
        }

        private static void ScaleCommandHandler(string val)
        {
            throw new NotImplementedException();
        }

        private static void ChordProgressionCommandHandler(string val)
        {
            throw new NotImplementedException();
        }
    }
}
