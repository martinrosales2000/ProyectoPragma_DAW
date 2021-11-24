using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pragma.Controllers
{
    public class PragmaViewsController : Controller
    {
        // GET: PragmaViews
        public ActionResult MantInventario()
        {
            return View();
        }

    }
}