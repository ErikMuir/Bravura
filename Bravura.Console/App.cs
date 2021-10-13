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
        private static readonly FluentConsole _console = new();
        private readonly string[] _args;
        private readonly RootCommand _rootCommand;

        public App(string[] args)
        {
            _args = args;
            _rootCommand = new RootCommand("A console app demonstrating the Bravura dotnet music theory library")
            {
                PitchCommand.Command,
                ChordQualityCommand.Command,
                ChordCommand.Command,
                ModeCommand.Command,
                ScaleCommand.Command,
                ChromaticScaleCommand.Command,
                ChordProgressionCommand.Command,
            };
            _rootCommand.Handler = CommandHandler.Create<Command>(_rootCommandHandler);
        }

        public Task<int> Run()
        {
            return _rootCommand.InvokeAsync(_args);
        }

        private void _rootCommandHandler(Command command)
        {
            if (command == null)
            {
                _console.Failure("Required command missing").LineFeed();
                _rootCommand.Invoke("-h");
            }
        }
    }
}
