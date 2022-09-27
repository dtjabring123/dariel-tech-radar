using System.CommandLine;

using System.CommandLine.Parsing;

namespace cloud;

public class Aux
{
  public static async Task<int> Run(string[] args)
  {

    var arg = new Argument<string>("name", "Your name.");
    var opt1 = new Option<string?>("--greeting", "The greeting to use.");
    var opt2 = new Option<bool>("--verbose", "Show the deets.");
    
    var cmd = new RootCommand("Greetings");

    cmd.AddArgument(arg);
    cmd.AddOption(opt1);
    cmd.AddOption(opt2);

    cmd.SetHandler<string, string?, bool>((name, greeting, verbose) =>
    {
      try
      {
        if (verbose)
          Console.Out.WriteLine($"About to greet '{name}'...");

        greeting ??= "Hi";
        Console.Out.WriteLine($"{greeting} {name}!");

        if (verbose)
          Console.Out.WriteLine($"done greeting");

        // return 0;
      }
      catch (System.Exception e)
      {

        if (verbose)
          Console.Out.Write(e);

        // return -1;
      }
    }
    , arg
    , opt1
    , opt2
    );

    return await cmd.InvokeAsync(args);
  }
}