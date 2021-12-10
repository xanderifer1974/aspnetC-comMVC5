using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {

        public ActionResult Usuario()
        {
            Usuario usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            //if (string.IsNullOrEmpty(usuario.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo nome é obrigatório!");
            //}

            //if(usuario.Senha != usuario.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("", "As senhas são diferentes!");
            //}

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }

            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}