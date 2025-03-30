using Microsoft.EntityFrameworkCore;
using PrimerProyecto.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuración explícita del DbContext
builder.Services.AddDbContext<ContextoTiendaRopa>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContextoTiendaRopa")));
var app = builder.Build();



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{url?}");

app.Run();
