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
        ClsRLogin clsrlogin = new ClsRLogin();

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
            else
            {
                clsrlogin.Create(usuario);

                return RedirectToAction("Inicio");
            }
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            return View();
        }
    }
}