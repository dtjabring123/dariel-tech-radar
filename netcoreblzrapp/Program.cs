using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace netcoreblzrapp
{

  class Converter<Object> : Newtonsoft.Json.JsonConverter<Object>
  {
    public override Object? ReadJson(JsonReader reader, Type objectType, Object? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
      throw new NotImplementedException();
    }

    public override void WriteJson(JsonWriter writer, Object? value, JsonSerializer serializer)
    {
      throw new NotImplementedException();
    }
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
