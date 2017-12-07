using HC_SB.EntidadesDominio.Autenticacion;
using HC_SB.Modelos.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC_SB.Controllers
{
    public class AdminUsuariosYRolesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: AdminUsuariosYRoles
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// se muestra todos los usuarios del sistema
        /// </summary>
        /// <returns></returns>
        public ActionResult listaUsuarios()
        {

            var users = db.Users.ToList();
            List<EDUsuarioSistema> listaUsuarios = new List<EDUsuarioSistema>();
            foreach (var user in users)
            {

                var EDUsuarioSistema = new EDUsuarioSistema
                {
                    IDUser = user.Id,
                    userName = user.UserName,
                    nombreCompleto = user.nombreCompleto 
                };
                listaUsuarios.Add(EDUsuarioSistema);

            }

            return View(listaUsuarios);
        }
    }
}