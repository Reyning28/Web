//Reyning Perdomo Feliz
//Matricula:2023-1110
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

// Conexión de Swagger :)
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {   
        Title = "API_PRACTICA🧠📚", 
        Version = "v1",
        Description = "🧠📚MI API CON .NET CORE🔍📊"
    });
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json","Tarea6_API v1");
        c.RoutePrefix = string.Empty;
    });
}

// Métodos de la tarea

var tarea = app.MapGroup("/tarea").WithTags("asignacion verdadera").WithDescription("Rutas de la asignacion verdadera");

tarea.MapGet("/noticias", () => URL.URLconexion());

tarea.MapPost("/registrousario", ([FromBody] RegistroUser usuario) => ManejadorUser.Registro(usuario));

tarea.MapPost("/loginUser", ([FromBody] LoginRequest datos) => ManejadorUser.IniciarSesion(datos));

tarea.MapGet("/clima", async (double lat, double lon, [FromServices] IHttpClientFactory httpClientFactory) =>
{
    string apiKey = "TU_API_KEY"; //LLave o key del Api
    var client = httpClientFactory.CreateClient();
    var url = $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

    var response = await client.GetAsync(url);
    if (!response.IsSuccessStatusCode)
    {
        return Results.Problem("No se pudo obtener la información del clima.");
    }

    var weatherData = await response.Content.ReadAsStringAsync();
    return Results.Ok(weatherData);
}).WithTags("Clima").WithDescription("Devuelve el clima basado en coordenadas de latitud y longitud");


app.Run();
