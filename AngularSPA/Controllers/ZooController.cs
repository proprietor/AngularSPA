using System.Web.Mvc;
using AngularSPA.Interfaces;
using AngularSPA.Services;
using AngularSPA.ViewModels;

namespace AngularSPA.Controllers
{
    public class ZooController : Controller
    {
        private IZooService zooService = new ZooService();

        public ActionResult Index()
        {
            ZooViewModel zooViewModel = zooService.GetZooViewModel();
            return View("Index", zooViewModel);
        }
    }
}
