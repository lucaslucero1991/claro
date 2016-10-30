using Claro_minicall.Models;
using System.Web.Mvc;

namespace Claro_minicall.Controllers
{
    public class ReferidoController : Controller
    {
        //
        // GET: /Referido/Inicio
        public ActionResult Inicio()
        {
            var referido = new Referido() { Name = "Lucas" };
            return View();
        }

    }
}
