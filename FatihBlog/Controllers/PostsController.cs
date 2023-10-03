using FatihBlog.Data.Abstract;
using FatihBlog.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;

namespace FatihBlog.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _repository;
        public PostsController(IPostRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.Posts.ToList());
        }
    }
}