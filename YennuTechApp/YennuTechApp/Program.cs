using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Repository.Base;
using Microsoft.Extensions.DependencyInjection;
using Repository.DataClass.Abstraction;
using Repository.DataClass;
using Service.Abstraction;
using Service.Location;

namespace YennuTechApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            builder.Services.AddScoped(typeof(ILocationRepository), typeof(LocationRepository));
            builder.Services.AddTransient(typeof(ILocationService), typeof(LocationService));

            builder.Services.AddControllers();

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
