using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Safra.CreditCard.Transaction.Integration;

public static class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
        =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
            //.UseSerilog((hostingContext, loggerConfiguration) =>
            //{
            //    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
            //})
            
}
