using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfiguration config = builder.Build();
var connectionString = config["ConnectionStrings:DefaultConnection"] ?? "Cadena no encontrada";

Console.WriteLine("Hello, Platzi!");
Console.WriteLine($"Cadena de conexión simulada: {connectionString}");
