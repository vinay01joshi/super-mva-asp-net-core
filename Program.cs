using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace supermva
{
    class Program
    {
        static void Main(string[] args)
        {
           var host = new WebHostBuilder()
                        .UseUrls("http://localhost:3000") // optional - Default 5000
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseStartup<Startup>()
                        .Build();
            host.Run();
        }
    }
}
