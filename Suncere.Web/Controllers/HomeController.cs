using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Suncere.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SuncereControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}