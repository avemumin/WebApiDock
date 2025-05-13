using Microsoft.EntityFrameworkCore;
using WebApiDock;
using WebApiDock.Data;
using WebApiDock.Services;
using WebApiDock.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connString = builder.Configuration.GetConnectionString("PostDb");

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
  options.UseNpgsql(connString);
});
builder.Services.AddScoped<UserSeeder>();
builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();

//var scope = app.Services.CreateScope();
//var seeder = scope.ServiceProvider.GetRequiredService<UserSeeder>();
//seeder.UserSeed();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
