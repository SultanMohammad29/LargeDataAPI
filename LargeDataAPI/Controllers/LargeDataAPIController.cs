using LargeDataAPI.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LargeDataAPI.Controllers
{
    public class LargeDataAPIController : Controller
    {
        private readonly AppDBContext _context;

        public LargeDataAPIController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Pagination for large data
        [HttpGet]
        public IActionResult GetProducts(int page = 1, int pageSize = 20)
        {
            var data = _context.Products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return Ok(data);
        }
        //Filtering for large data
        public IActionResult GetProductsByCategory(string category)
        {
            var data = _context.Products.Where(p => p.Category == category).ToList();
            return Ok(data);
        }
    }
}
