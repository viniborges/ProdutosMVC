using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class ContadorController : Controller
    {
        // GET: Contador
        public ActionResult Index()
        {
            object valor = Session["contador"];
            int cont = Convert.ToInt32(valor);
            cont++;
            Session["Contador"] = cont;
            return View(cont);
        }
    }
}