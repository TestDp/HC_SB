using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC_SB.Controllers.HistoriasClinicas
{
    public class IdentificacionPacienteController : Controller
    {
        // GET: IdentificacionPaciente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearPaciente() 
        {
            return View();
        }
    }
}