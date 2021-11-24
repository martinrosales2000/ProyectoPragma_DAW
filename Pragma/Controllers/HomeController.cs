using Pragma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pragma.Controllers
{
    public class HomeController : Controller
    {
        private pragmaDBConnection db = new pragmaDBConnection();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "nombre_usuario,password")] Login user)
        {

            foreach (var item in db.Usuarios.ToList())
            {

                if (item.nombre_usuario == user.nombre_usuario)
                {
                    if (item.password == user.password)
                    {
                        string rol = item.tipo_usuario;
                        if (item.tipo_usuario.Contains("Administrador"))
                        {
                            ViewBag.rol = "Admin";
                            ViewBag.name = user.nombre_usuario;
                            Session["login"] = "ok";
                            Session["Admin"] = "ok";
                            Session["User"] = user.nombre_usuario;
                            return RedirectToAction("Index", "Inventarios", "Inventarios");
                        }
                        else
                        {
                            ViewBag.rol = "Usuario";
                            ViewBag.name = user.nombre_usuario;
                            Session["login"] = "ok";
                            Session["User"] = user.nombre_usuario;
                            Session["Usuario"] = "ok";
                            return RedirectToAction("Index", "Inventarios", "Inventarios");
                        }

                    }
                    else
                    {
                        
                    }

                }
                else
                {
                    
                }

            }
            return View("Index");
        }

        public ActionResult LogOut()
        {
            Session["Admin"] = null;
            Session["User"] = null;
            Session["Usuario"] = null;
            Session["login"] = null;
            return View("Index");
        }

    }
}