using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.Parsing;
using System.Threading.Tasks;
using MuirDev.ConsoleTools;

namespace Bravura.Console
{
    public class App
    {
        private readonly FluentConsole _console = new FluentConsole();

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

            ChordQualityCommand = new Command("chord-quality") { new Argument<string>("chordQuality") };
            ChordQualityCommand.Handler = CommandHandler.Create<string>(ChordQualityCommandHandler);

            ChordCommand = new Command("chord") { new Argument<string>("chord") };
            ChordCommand.Handler = CommandHandler.Create<string>(ChordCommandHandler);

            ModeCommand = new Command("mode") { new Argument<string>("mode") };
            ModeCommand.Handler = CommandHandler.Create<string>(ModeCommandHandler);

            ScaleCommand = new Command("scale") { new Argument<string>("scale") };
            ScaleCommand.Handler = CommandHandler.Create<string>(ScaleCommandHandler);

            ChordProgressionCommand = new Command("chord-progression") { new Argument<string>("chordProgression") };
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

        private void ChordQualityCommandHandler(string chordQuality)
        {
            _console.WriteLine($"Chord Quality: {chordQuality}");
        }

        private void ChordCommandHandler(string chord)
        {
            _console.WriteLine($"Chord: {chord}");
        }

        private void ModeCommandHandler(string mode)
        {
            _console.WriteLine($"Mode: {mode}");
        }

        private void ScaleCommandHandler(string scale)
        {
            _console.WriteLine($"Scale: {scale}");
        }

        private void ChordProgressionCommandHandler(string chordProgression)
        {
            _console.WriteLine($"Chord Progression: {chordProgression}");
        }
    }
}
