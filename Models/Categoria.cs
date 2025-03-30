using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimerProyecto.Models;
public class Categoria 
{
    public int IdCategoria {get;set;}
    [Required(ErrorMessage ="Por favor ingrese el nombre de la categoria")]
    public string? NombreCategoria {get;set;}
}