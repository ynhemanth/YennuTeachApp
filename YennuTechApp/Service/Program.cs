using Repository.DataClass.Abstraction;
using Repository.DataClass;
using Service.Abstraction;
using Service.Location;
using Repository.Base;
using Service.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient<ILocationRepository, LocationRepository>();
builder.Services.AddTransient<ILocationService, LocationService>();

builder.Services.AddAutoMapper(typeof(AutoMapperServiceConfig));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
