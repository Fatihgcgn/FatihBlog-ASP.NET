namespace FatihBlog.Entity;

public class User
{
    public int UserId { get; set; }
    public string? UserName { get; set; }
    public List<Post> Post { get; set; } = new List<Post>();
    public List<Comment> Comments { get; set; } = new List<Comment>();
}
