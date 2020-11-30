using System.Web.Mvc;

namespace ConsultorioWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sistema de gerenciamento de clínica odontológica";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Equipe de Desenvolvimento";

            return View();
        }
    }
}