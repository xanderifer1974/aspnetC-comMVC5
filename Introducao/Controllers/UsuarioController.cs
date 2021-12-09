using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
       
        public ActionResult Index()
        {
            Usuario usuario = new Usuario();

            return View(usuario);
        }
    }
}