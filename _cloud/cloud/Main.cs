
using System.Diagnostics;
using CommandLine;

namespace cloud;
public class Options
{
  [CommandLine.Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
  public bool Verbose { get; set; }

  [CommandLine.Option('c', "config", Required = false, HelpText = "Path to config file.")]
  public string InputFile { get; set; }

  [CommandLine.Option('d', "debug", Required = false, HelpText = "Debug option.")]
  public string OutputFile { get; set; }

}

public class Main
{
  public class TextFile
  {
    public string Name = String.Empty;
    public string Content = String.Empty;
  }

  string process(string command, string? parameters = null, TextFile? t = null)
  {
    var p = new Process();

    if (!string.IsNullOrEmpty(parameters)) p.StartInfo.Arguments = parameters;

    p.StartInfo.UseShellExecute = false;

    p.StartInfo.RedirectStandardOutput = true;
    p.StartInfo.FileName = command;

    p.StartInfo.CreateNoWindow = true;
    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
    p.StartInfo.UseShellExecute = false;

    p.StartInfo.RedirectStandardError = true;
    p.StartInfo.RedirectStandardOutput = true;
    var stdOutput = new System.Text.StringBuilder();
    if (t != null)
      File.WriteAllText(
        Path.Combine(p.StartInfo.WorkingDirectory, t.Name)
      , t.Content
      );

    p.OutputDataReceived += (sender, args) => stdOutput.AppendLine(args.Data); // Use AppendLine rather than Append since args.Data is one line of output, not including the newline character.



    string stdError = null;
    try
    {
      p.Start();
      p.BeginOutputReadLine();
      stdError = p.StandardError.ReadToEnd();
      p.WaitForExit();
    }
    catch (Exception e)
    {
      throw new Exception(@$"OS process interrupted while executing '{command} {parameters}': " + e.Message, e);
    }

    if (p.ExitCode == 0)
      return stdOutput.ToString();

    var message = new System.Text.StringBuilder();

    if (!string.IsNullOrEmpty(stdError))
      message.AppendLine(stdError);

    if (stdOutput.Length != 0)
    {
      message.AppendLine("Std output:");
      message.AppendLine(stdOutput.ToString());
    }

    throw new Exception(@$"{command} finished with exit code = {p.ExitCode}: {message.ToString()}");
  }

  static void main(string[] args)
  {
    Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(o =>
    {
      Console.WriteLine($"arguments: -v {o.Verbose}");
      if (o.Verbose) Console.WriteLine("verbose mode");
    });
  }

  public void Run(string? input)
  {
    if (String.IsNullOrEmpty(input)) return;

    Console.WriteLine(@$"echo:{input}");

    // main(new string[] { "--verbose" });
    var p = process("terraform", "init", new TextFile
    {
      Content = @"terraform {
  required_version = "">= 0.12""
    }",
      Name = "versions.tf"
    });



    Console.Write(p);
    Console.WriteLine();

    p = process("terraform", "plan");


    Console.Write(p);
    Console.WriteLine();
    
    main(input.Split(' '));

    // // Aux.Run(new string[] { "--file", "test.txt" });
    // Aux.Run(input.Split(' '));

    Run(Console.ReadLine());
  }
}