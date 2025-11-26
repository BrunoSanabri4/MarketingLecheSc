using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Marketing_Sc.Data;

var url = Environment.GetEnvironmentVariable("DATABASE");
Console.WriteLine($"La cadena de conexión es esta: {url}");

var builder = WebApplication.CreateBuilder(args);

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost", policy =>
    {
        policy.WithOrigins("http://localhost:5173")  // Permite solicitudes solo desde localhost:5173
              .AllowAnyMethod()                      // Permite cualquier método (GET, POST, PUT, DELETE, etc.)
              .AllowAnyHeader();                     // Permite cualquier encabezado
    });
});

// Registra el servicio ApiClient con HttpClient
builder.Services.AddHttpClient<ApiClient>();

// Configuración de DbContext
builder.Services.AddDbContext<Marketing_ScContext>(options =>
    options.UseNpgsql(url));

// Agregar servicios al contenedor
builder.WebHost.UseUrls("http://0.0.0.0:8080");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Habilitar CORS
app.UseCors("AllowLocalhost");

// Ejecutar migraciones al iniciar la aplicación
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<Marketing_ScContext>();
    db.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Consumir la API externa de tu compañero
var apiClient = app.Services.GetRequiredService<ApiClient>();
await apiClient.GetCampaniaData();  // Llamada a la API de tu compañero

app.Run();
