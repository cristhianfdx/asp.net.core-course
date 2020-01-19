using System;
using App2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace App2.Controllers{

    public class AsignaturaController : Controller
    {
        public IActionResult Index(){

            var asignatura = new Asignatura(){
                Nombre = "Programación",
                UniqueId = Guid.NewGuid().ToString()
            };

            ViewBag.Fecha = DateTime.Now;

            return View(asignatura);
        }

        public IActionResult MultiAsignatura()
        {
            var listaAsignatura = new List<Asignatura>(){
                new Asignatura{
                    Nombre = "Programación",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura{
                    Nombre = "Español",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura{
                    Nombre = "Ciencias Naturales",
                    UniqueId = Guid.NewGuid().ToString()
                },
                
            };
            return View("MultiAsignatura",listaAsignatura);

        }
    }
}