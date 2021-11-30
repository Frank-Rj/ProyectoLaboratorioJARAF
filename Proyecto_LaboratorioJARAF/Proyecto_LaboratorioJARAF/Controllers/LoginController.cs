using Proyecto_LaboratorioJARAF.Models;
using Proyecto_LaboratorioJARAF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_LaboratorioJARAF.Controllers
{
    public class LoginController : Controller
    {
        // Login
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(USUARIO usuario)
        {
            if (usuario.Usuario1 == null & usuario.Contraseña == null)
            {
                return RedirectToAction("Error");
            }
            else if(usuario.Usuario1 == "Rocio" & usuario.Contraseña == "Jas")
            {
                return RedirectToAction("Inicio");
            }
            else if (usuario.Usuario1 == "Adamaris" & usuario.Contraseña == "Yan")
            {
                return RedirectToAction("Inicio");
            }
            else if (usuario.Usuario1 == "Jose" & usuario.Contraseña == "Fran")
            {
                return RedirectToAction("Inicio");
            }
            else if (usuario.Usuario1 == "Franklin" & usuario.Contraseña == "Noe")
            {
                return RedirectToAction("Inicio");
            }
            else if (usuario.Usuario1 == "Anderson" & usuario.Contraseña == "stan")
            {
                return RedirectToAction("Inicio");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        // Error
        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }

        // Inicio
        public ActionResult Inicio()
        {
            return View();
        }
    }
}