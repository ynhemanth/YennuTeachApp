using Microsoft.EntityFrameworkCore;
using Repository.Base;
using Repository.Configuration;
using Repository.DataClass;
using Repository.DataClass.Abstraction;
using Repository.Entity.DBContext;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")
));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(ILocationRepository), typeof(LocationRepository));

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
