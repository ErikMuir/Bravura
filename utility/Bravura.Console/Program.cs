global using System;
global using System.Collections.Generic;
global using System.CommandLine;
global using System.CommandLine.NamingConventionBinder;
global using System.Linq;
global using MuirDev.ConsoleTools;
global using Bravura.Common.Utilities;
global using Bravura.Tonality;
global using Bravura.Tonality.Analysis;
global using Bravura.Console.Commands;

var rootCommand = new RootCommand("A console app demonstrating the Bravura dotnet music theory library")
{
    PitchCommand.Command,
    ChordQualityCommand.Command,
    ChordCommand.Command,
    ModeCommand.Command,
    ScaleCommand.Command,
    ChromaticScaleCommand.Command,
    ChordProgressionCommand.Command,
    TransposeCommand.Command,
    AnalyzedChordCommand.Command,
};

rootCommand.Handler = CommandHandler.Create<Command>(command =>
{
    if (command == null)
    {
        new FluentConsole().Failure("Required command missing").LineFeed();
        rootCommand.Invoke("-h");
    }
});

rootCommand.Invoke(args);
