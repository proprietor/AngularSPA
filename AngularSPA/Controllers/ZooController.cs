using System.Web.Mvc;
using System.Web.Script.Serialization;
using AngularSPA.Interfaces;
using AngularSPA.Services;

namespace AngularSPA.Controllers
{
    public class ZooController : Controller
    {
        private IZooService zooService = new ZooService();

        public ActionResult Index()
        {
            string json = new JavaScriptSerializer().Serialize(zooService.GetAnimals());
            return View("Index", (object)json);
        }
    }
}
