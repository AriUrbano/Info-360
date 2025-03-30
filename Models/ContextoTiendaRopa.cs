using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimerProyecto.Models;

namespace PrimerProyecto.Models;


public class ContextoTiendaRopa : DbContext
{

    // En tu ContextoTiendaRopa.cs
public ContextoTiendaRopa() : this(
    new DbContextOptionsBuilder<ContextoTiendaRopa>()
        .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Wear_Swise_Temp;Trusted_Connection=True;")
        .Options)
{
}
    public ContextoTiendaRopa(DbContextOptions<ContextoTiendaRopa> options): base(options) {}
    
    public DbSet<Producto> Productos {get;set;}
    public DbSet<Categoria> Categorias {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria {IdCategoria = 1, NombreCategoria = "Prendas_Superiores"},
            new Categoria {IdCategoria = 2, NombreCategoria = "Prendas_Inferiores"},
            new Categoria {IdCategoria = 3, NombreCategoria = "Zapatos"},
            new Categoria {IdCategoria = 4, NombreCategoria = "Accesorios"}
        );

        modelBuilder.Entity<Producto>().HasData(
            new Producto {IdProducto = 1, 
            IdCategoria = 1, 
            Descripcion = "Remeras para Hombres y Mujeres", 
            NombreProducto = "Remeras",
            Precio = (decimal)2.99,
            },
            new Producto {IdProducto = 2, 
            IdCategoria = 1, 
            Descripcion = "Buzos para Hombres y Mujeres", 
            NombreProducto = "Buzos",
            Precio = (decimal)5.99,
            },
            new Producto {IdProducto = 3, 
            IdCategoria = 1, 
            Descripcion = "Camperas para Hombres y Mujeres", 
            NombreProducto = "Camperas",
            Precio = (decimal)7.99,
            },
            new Producto {IdProducto = 4, 
            IdCategoria = 1, 
            Descripcion = "Tops para Mujeres", 
            NombreProducto = "Tops",
            Precio = (decimal)4.99,
            },
            new Producto {IdProducto = 5, 
            IdCategoria = 1, 
            Descripcion = "Sacos para Hombres y Mujeres", 
            NombreProducto = "Sacos",
            Precio = (decimal)10.99,
            }
            
        );
    }    
}