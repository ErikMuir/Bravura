using System.CommandLine;
using System.CommandLine.Invocation;
using MuirDev.ConsoleTools;
using Bravura.Tonality;

namespace Bravura.Console
{
    public static class ChordCommand
    {
        private static readonly FluentConsole _console = new FluentConsole();

        static ChordCommand()
        {
            Command.Handler = CommandHandler.Create<string>(_handler);
        }

        public static Command Command = new Command("chord") { new Argument<string>("val") };

        private static void _handler(string val)
        {
            throw new NotImplementedException();
        }
    }
}
