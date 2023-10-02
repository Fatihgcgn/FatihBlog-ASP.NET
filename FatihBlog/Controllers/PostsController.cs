using FatihBlog.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;

namespace FatihBlog.Controllers
{

    public class PostsController : Controller
    {
        private readonly FatihBlogContext _context;

        public PostsController(FatihBlogContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }


}
