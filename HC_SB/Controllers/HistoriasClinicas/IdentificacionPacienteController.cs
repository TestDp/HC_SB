using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HC_SB.Authorize;


namespace HC_SB.Controllers.HistoriasClinicas
{
    public class IdentificacionPacienteController : Controller
    {
        // GET: IdentificacionPaciente
        public ActionResult Index()
        {
            return View();
        }

       [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult CrearPaciente() 
        {
            return View();
        }
    }
}