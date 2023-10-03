using FatihBlog.Entity;

namespace FatihBlog.Data.Abstract
{
    public interface IPostRepository
    {
        IQueryable<Post> Posts { get; }
        void CreatePost(Post post);
    }
}