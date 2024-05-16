using Microsoft.EntityFrameworkCore;
using Repository.Entity.DBContext;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")
));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
