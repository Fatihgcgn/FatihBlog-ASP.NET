using FatihBlog.Data.Abstract;
using FatihBlog.Data.Concrete.EfCore;
using FatihBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> Details(string url)
        {
            return View(await _postRepository.Posts.FirstOrDefaultAsync(p=>p.Url == url));
        }
    }
}