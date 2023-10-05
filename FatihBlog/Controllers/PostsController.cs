using FatihBlog.Data.Abstract;
using FatihBlog.Data.Concrete.EfCore;
using FatihBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FatihBlog.Controllers
{
    public class PostsController : Controller
    {
        private IPostRepository _postRepository;
        private ITagRepository _tagRepository;

        public PostsController(IPostRepository postRepository,ITagRepository tagRepository)
        {
            _postRepository = postRepository;
            _tagRepository = tagRepository;
        }
        public IActionResult Index()
        {
            return View(
                new PostsViewModel
                {
                    Posts = _postRepository.Posts.ToList(),
                    Tags = _tagRepository.Tags.ToList()
                }
            );
        }
    }
}