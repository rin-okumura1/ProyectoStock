using ProyectoStock.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProyectoStock.Datos
{
    public class BaseDeDatos : DbContext
    {
        //public static List<Usuario> Usuarios { get; set; } = new List<Usuario>(); 
        public BaseDeDatos(DbContextOptions <BaseDeDatos> opciones) : base(opciones)
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
    }
}
