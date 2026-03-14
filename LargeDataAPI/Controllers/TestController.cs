using Microsoft.AspNetCore.Mvc;

namespace LargeDataAPI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
