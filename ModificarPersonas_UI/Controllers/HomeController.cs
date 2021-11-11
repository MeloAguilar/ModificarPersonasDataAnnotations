using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModificarPersonas_Entities;

namespace ModificarPersonas_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("id,nombre,apellidos,fechaNac,telefono")] clsPersona persona)
        {
            if (!ModelState.IsValid)
            {

                return View(nameof(Index));

            }
            else
            {

                ViewBag.Persona = persona;
                return View("PersonaModificada");

            }


        }
    }


}
