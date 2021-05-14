using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace YOURPROJECT
{
  public class Program
  {
    public static void Main(string[] args)
    // This is all necessary boilerplate
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}