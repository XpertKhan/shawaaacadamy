
using DAL;
using System.Web.Mvc;
 

namespace Shawaa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ClassRepository _repo = new ClassRepository();
            ViewBag.Title = "Dashboard";
            var da = _repo.GetAll();
            return View();
        }
    }
}
