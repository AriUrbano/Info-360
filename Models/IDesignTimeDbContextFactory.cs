// En Models/DesignTimeDbContextFactory.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace PrimerProyecto.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ContextoTiendaRopa>
    {
        public ContextoTiendaRopa CreateDbContext(string[] args)
        {
            Console.WriteLine("Directorio actual: " + Directory.GetCurrentDirectory());
            
            // Configuración explícita
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Info-360"))
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            string connectionString = config.GetConnectionString("ContextoTiendaRopa");
            Console.WriteLine("Cadena de conexión: " + connectionString);

            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("No se encontró la cadena de conexión");

            var options = new DbContextOptionsBuilder<ContextoTiendaRopa>()
                .UseSqlServer(connectionString)
                .Options;

            return new ContextoTiendaRopa(options);
        }
    }
}