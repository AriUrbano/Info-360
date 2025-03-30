using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimerProyecto.Models;

    public class Producto 
    {
    public int IdProducto { get; set; }

    [Required(ErrorMessage = "Por favor ingrese el nombre del producto")]
    public string? NombreProducto { get; set; }

    [Required(ErrorMessage = "Por favor ingrese el precio")]
    [Column(TypeName = "decimal(20, 2)")]
    public decimal Precio { get; set; }

    public decimal Descuento => .10m;

    public decimal CantidadDescuento => Precio * Descuento;

    public decimal PrecioFinal => Precio - CantidadDescuento;

    public string? Descripcion { get; set; }

    public string Url => NombreProducto == null ? "" : NombreProducto.Replace(' ', '-');
    [Required(ErrorMessage = "Por favor ingrese la categoria")]
    public int IdCategoria {get;set;}
    public Categoria? Categoria {get;set;}

    }
