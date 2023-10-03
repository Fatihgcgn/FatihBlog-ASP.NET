using FatihBlog.Data.Abstract;
using FatihBlog.Data.Concrete.EfCore;
using FatihBlog.Entity;

namespace FatihBlog.Data.Concrete
{
    public class EfPostRepository : IPostRepository
    {
        private FatihBlogContext _context;

        public EfPostRepository(FatihBlogContext context)
        {
             _context = context;
        }
        
        public IQueryable<Post> Posts => _context.Posts;

        public void CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}