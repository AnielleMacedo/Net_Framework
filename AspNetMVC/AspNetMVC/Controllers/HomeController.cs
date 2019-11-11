using AspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC.Controllers
{
    public class HomeController : Controller
    {
        private static List<Livro> Livros;

        //cria um construtor p instanciar essa lista
        public HomeController()
        {
            if (Livros == null)
                Livros = new Livro().GetLivros();
        }

        //metodo padrao criado pelo AspNet p chamar o controller home e action index
        public ActionResult Index()
        {
            return View();//vamos criar essa view chamada index dentro de Home
        }
    }
}