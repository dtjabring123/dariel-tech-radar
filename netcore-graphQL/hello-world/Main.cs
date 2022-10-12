using System;
using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;

namespace gql
{
  public class Main
  {
    public async void Run(string? input)
    {
      

      if (string.IsNullOrEmpty(input)) return;

      var g = parse(input);

      Console.Write(await g.Greet(@$"{input}!"));

      Console.WriteLine();

      Run(Console.ReadLine());
    }

    private Graph parse(string input)
    {

      Console.WriteLine("input:");
      Console.Write(input);
      Console.WriteLine();

      return new Graph();
    }
  }

  internal class Graph
  {
    private readonly Schema helloSchema = Schema.For(@"
      type Query {
        hello: String
      }
    ");

    public async Task<string> Greet(string greeting)
    {
      return await helloSchema.ExecuteAsync(new GraphQLSerializer(), _ =>
      {
        _.Query = "{ hello }";
        _.Root = new { Hello = greeting };
      });
    }
  }
}