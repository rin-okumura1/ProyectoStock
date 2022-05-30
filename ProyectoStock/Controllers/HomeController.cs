using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoStock.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoStock.Datos;

namespace ProyectoStock.Controllers
{



    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BaseDeDatos _context;
        public HomeController(BaseDeDatos context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Visualizacion(Producto producto)
        {
            ViewBag.nombreProd = producto.idProducto;
            ViewBag.tipoProd = producto.Tipo;
            ViewBag.pesoProd = producto.Peso;
            return View();
        }

        [HttpGet]
        public IActionResult Ingreso()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Ingreso(Producto prod)
        {
            return   RedirectToAction("Visualizacion", "Home", prod);
        }

        public IActionResult Privacy()
        {
            return RedirectToAction("Ingreso", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
      
    }
}
