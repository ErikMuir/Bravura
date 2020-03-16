using System.CommandLine;
using System.CommandLine.Invocation;
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
            throw new NotImplementedException();
        }
    }
}
