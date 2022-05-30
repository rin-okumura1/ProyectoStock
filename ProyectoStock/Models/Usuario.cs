using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoStock.Models
{
    public class Usuario
    {
        [Display(Name = "email")]
        [Key]
        public String email{ get; set; }

    }
}
