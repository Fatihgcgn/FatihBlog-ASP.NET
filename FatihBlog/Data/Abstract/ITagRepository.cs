using FatihBlog.Entity;

namespace FatihBlog.Data.Abstract
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }
        void CreateTag(Tag tag);
    }
}