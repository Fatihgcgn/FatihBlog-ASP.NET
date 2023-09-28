using FatihBlog.Entity;
using Microsoft.EntityFrameworkCore;

namespace FatihBlog.Data.Concrete.EfCore
{
    public class FatihBlogContext : DbContext
    {
        public FatihBlogContext(DbContextOptions<FatihBlogContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<User> Users => Set<User>();
    }
}