using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Pessoa pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Alexandre Ferreira",
                Tipo = "Funcionário"
            };

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            ViewBag.id = pessoa.PessoaId;
            ViewBag.nome = pessoa.Nome;
            ViewBag.tipo = pessoa.Tipo;

            return View(pessoa);
        }
        

        public ActionResult Contato()
        {
            return View();
        }

        //Passando parâmetros na view
        //[HttpPost]
        //public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        //{
        //    ViewData["PessoaId"] = PessoaId;
        //    ViewData["Nome"] = Nome;
        //    ViewData["Tipo"] = Tipo;

        //    return View();
        //}

        //Passando os parâmetross por formsCollection informando o nome do campo formulário
        //[HttpPost]
        //public ActionResult Lista(FormCollection form)
        //{
        //    ViewData["PessoaId"] = form["PessoaId"];
        //    ViewData["Nome"] = form["Nome"];
        //    ViewData["Tipo"] = form["Tipo"];

        //    return View();
        //}

        //Passando os parâmetross por view tipada, somente dá para usar assim, se o formulário já trabalhar com view tipada.
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }
    }


}