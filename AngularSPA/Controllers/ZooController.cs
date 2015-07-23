using System.Web.Mvc;
using AngularSPA.Interfaces;
using AngularSPA.Services;

namespace AngularSPA.Controllers
{
    public class ZooController : Controller
    {
        private IZooService zooService = new ZooService();

        public ActionResult Index()
        {
            return View(zooService.GetZooViewModel());
        }
    }
}
