using HC_SB.Authorize;
using HC_SB.EntidadesDominio.Autenticacion;
using HC_SB.Modelos.Autenticacion;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HC_SB.Controllers
{
    public class AdminUsuariosYRolesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
      

        /// <summary>
        /// se muestra todos los usuarios del sistema
        /// </summary>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
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

        /// <summary>
        /// Metodo para eliminar un usuario del sistema
        /// </summary>
        /// <param name="idUser">id del usuario a borrar</param>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult EliminarUsuario(string idUser)
        {

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var users = userManager.Users.ToList();
            var user = users.Find(u => u.Id == idUser);
            userManager.Delete(user);
            return RedirectToAction("listaUsuarios");

        }

        /// <summary>
        /// crear un nuevo rol
        /// </summary>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult CrearRol()
        {            
            return View();
        }

        /// <summary>
        /// Crear un nuevo Rol
        /// </summary>
        /// <param name="Role"></param>
        /// <returns></returns>
        [HttpPost]
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult CrearRol(IdentityRole Role)
        {
            db.Roles.Add(Role);
            db.SaveChanges();
            return RedirectToAction("listaRoles");
        }

        /// <summary>
        /// se muestra todos los roles del sistema
        /// </summary>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult listaRoles()
        {

            var users = db.Roles.ToList();
            List<EDRol> listaRoles = new List<EDRol>();
            foreach (var user in users)
            {

                var EDRol = new EDRol
                {
                    IdRol = user.Id,
                    nombreRol = user.Name
                };
                listaRoles.Add(EDRol);

            }

            return View(listaRoles);
        }

        /// <summary>
        /// Metodo para listar todos los roles del usuario recibe como parametro el id del usuario
        /// </summary>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult RolesPorUsuario(string id)
        {

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var rolMaager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var user = userManager.Users.ToList().Find(u => u.Id == id);
            var roles = rolMaager.Roles.ToList();
            var rolesUser = new List<EDRol>();
            if (user.Roles != null)
            {

                foreach (var rol in user.Roles)
                {
                    var role = roles.Find(r => r.Id == rol.RoleId);
                    var EDRol = new EDRol
                    {
                        IdRol = role.Id,
                        nombreRol = role.Name

                    };
                    rolesUser.Add(EDRol);
                }

            }
            var EDUsuarioSistema = new EDUsuarioSistema
            {
                IDUser = user.Id,
                userName = user.UserName,
                nombreCompleto = user.nombreCompleto,
                roles = rolesUser

            };
            return View(EDUsuarioSistema);
        }

        /// <summary>
        /// Metodo para asignarle un rol a un usuario del sistema
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult AgregarRolUsuario(string id)
        {

            var user = db.Users.Find(id);
            var EDUsuarioSistema = new EDUsuarioSistema
            {
                IDUser = user.Id,
                userName = user.UserName,
                nombreCompleto = user.nombreCompleto,

            };
            ViewBag.rol = new SelectList(db.Roles, "id", "Name");
            return View(EDUsuarioSistema);
        }
        
        [HttpPost]
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult AgregarRolUsuario(EDUsuarioSistema usuario)
        {

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var rolMaager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            var user = userManager.Users.ToList().Find(u => u.Id == usuario.IDUser);
            var rol = rolMaager.Roles.ToList().Find(r => r.Id == usuario.rol);
            if (!userManager.IsInRole(user.Id, rol.Name))
            {

                userManager.AddToRole(user.Id, rol.Name);
            }

            return RedirectToAction("listaUsuarios");

        }

        /// <summary>
        /// metodo para eliminar un rol al usuario 
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="idRol"></param>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult EliminarRolUsuario(string idUser, string idRol)
        {

            if (string.IsNullOrEmpty(idUser) || string.IsNullOrEmpty(idRol))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var rolMaager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            var user = userManager.Users.ToList().Find(u => u.Id == idUser);
            var rol = rolMaager.Roles.ToList().Find(r => r.Id == idRol);

         
            if (userManager.IsInRole(user.Id, rol.Name))
            {
                userManager.RemoveFromRole(user.Id, rol.Name);
            }

            /// retornando la vista para mostrar el usuario
            var Listaroles = rolMaager.Roles.ToList();
            var rolesUser = new List<EDRol>();
            if (user.Roles != null)
            {

                foreach (var rolUser in user.Roles)
                {
                    var role = Listaroles.Find(r => r.Id == rolUser.RoleId);
                    var EDRol = new EDRol
                    {
                        IdRol = role.Id,
                        nombreRol = role.Name

                    };
                    rolesUser.Add(EDRol);
                }

            }
            var EDUsuarioSistema = new EDUsuarioSistema
            {
                IDUser = user.Id,
                userName = user.UserName,
                nombreCompleto = user.nombreCompleto,
                roles = rolesUser
            };
            return View("RolesPorUsuario", EDUsuarioSistema);
        }

        /// <summary>
        /// Metodo para eliminar Roles
        /// </summary>
        /// <param name="idRol"></param>
        /// <param name="rolName"></param>
        /// <returns></returns>
        [HC_SBAuthorize(Roles = "Admin")]
        public ActionResult EliminarRol(string idRol, string rolName)
        {

            var rol = new IdentityRole();
            rol.Id = idRol;
            rol.Name = rolName;
            var rolMaager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var roles = rolMaager.Roles.ToList();
            var rolDe = roles.Find(r => r.Id == rol.Id);
            rolMaager.Delete(rolDe);
            return RedirectToAction("listaRoles");
        }
    }
}