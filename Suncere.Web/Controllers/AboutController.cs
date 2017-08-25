using System.Web.Mvc;

namespace Suncere.Web.Controllers
{
    public class AboutController : SuncereControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}