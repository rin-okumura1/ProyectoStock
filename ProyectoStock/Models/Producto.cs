using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProyectoStock.Models
{
    public class Producto
    {
        [Display(Name = "Id")]
        [Key]
        public int idProducto{ get; set; }
        [Display(Name = "Nombre de Tipo")]
        public string Tipo { get; set; }
        [Display(Name = "Nombre de Peso")]
        public int Peso { get; set; }
    }
}
