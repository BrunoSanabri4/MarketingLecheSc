using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Marketing_Sc.Data;
var url = Environment.GetEnvironmentVariable("DATABASE");
Console.WriteLine($"La cadena de conexión es esta: {url}");

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Marketing_ScContext>(options =>
    options.UseNpgsql(url));



// Add services to the container.
builder.WebHost.UseUrls("http://0.0.0.0:8080");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<Marketing_ScContext>();
    db.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
