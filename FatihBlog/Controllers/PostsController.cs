using FatihBlog.Data.Abstract;
using FatihBlog.Data.Concrete.EfCore;
using FatihBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FatihBlog.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _postRepository;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            return View(
                new PostsViewModel
                {
                    Posts = _postRepository.Posts.ToList()
                }
            );
        }
    }
}