using System;
using App2.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace App2.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            /* 
            var escuela = new Escuela();

            escuela.AnhoDeCreacion = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Mi Escuela";
            escuela.Ciudad = "Bogotá";
            escuela.Direccion ="Calle Falsa";
            escuela.Pais = "Colombia";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            */

            var escuela =_context.Escuelas.FirstOrDefault();

            ViewBag.CosaDinamica = "La Monja";

            return View(escuela);
        }
    }
}
