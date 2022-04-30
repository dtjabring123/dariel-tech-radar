using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcGreeterClient
{
  class Program
  {
    // Additional configuration is required to successfully run gRPC on macOS.
    // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
    static async Task Main(string[] args)
    {

      // This switch must be set before creating the GrpcChannel/HttpClient.
      AppContext.SetSwitch(
          "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

      // The port number(5001) must match the port of the gRPC server.
      // using var channel = GrpcChannel.ForAddress("https://localhost:5001");
      var channel = GrpcChannel.ForAddress("http://localhost:5001");

      var client = new Greeter.GreeterClient(channel);
      var reply = await client
        .SayHelloAsync(
            new HelloRequest { Name = "GreeterClient" }
          );

      Console.WriteLine("Greeting: " + reply.Message);
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}